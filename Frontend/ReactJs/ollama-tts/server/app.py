import json
import os
from http.server import BaseHTTPRequestHandler, ThreadingHTTPServer
from urllib.error import HTTPError, URLError
from urllib.request import Request, urlopen


PORT = int(os.environ.get("PORT", "5000"))
OLLAMA_HOST = os.environ.get("OLLAMA_HOST", "http://localhost:11434")
DEFAULT_MODEL = os.environ.get("OLLAMA_MODEL", "llama3")


class ChatHandler(BaseHTTPRequestHandler):
    def do_OPTIONS(self):
        self.send_response(204)
        self.send_cors_headers()
        self.end_headers()

    def do_GET(self):
        if self.path in ("/", "/api/health"):
            self.send_json(
                {
                    "status": "ok",
                    "ollamaHost": OLLAMA_HOST,
                    "defaultModel": DEFAULT_MODEL,
                }
            )
            return

        if self.path == "/api/models":
            try:
                self.send_json(call_ollama("/api/tags", method="GET"))
            except RuntimeError as error:
                self.send_json({"error": str(error)}, status=502)
            return

        self.send_json({"error": "Route not found"}, status=404)

    def do_POST(self):
        if self.path != "/api/chat":
            self.send_json({"error": "Route not found"}, status=404)
            return

        try:
            payload = self.read_json_body()
            user_message = payload.get("message", "").strip()
            model = payload.get("model", DEFAULT_MODEL).strip() or DEFAULT_MODEL
            messages = normalize_messages(payload.get("messages", []), user_message)

            if not user_message:
                self.send_json({"error": "Message is required"}, status=400)
                return

            response = call_ollama(
                "/api/chat",
                {
                    "model": model,
                    "messages": messages,
                    "stream": False,
                },
            )

            reply = response.get("message", {}).get("content", "").strip()
            self.send_json({"reply": reply or "Ollama returned an empty response."})
        except ValueError as error:
            self.send_json({"error": str(error)}, status=400)
        except RuntimeError as error:
            self.send_json({"error": str(error)}, status=502)

    def read_json_body(self):
        content_length = int(self.headers.get("Content-Length", "0"))
        if content_length == 0:
            return {}

        raw_body = self.rfile.read(content_length).decode("utf-8")
        try:
            return json.loads(raw_body)
        except json.JSONDecodeError as error:
            raise ValueError("Request body must be valid JSON") from error

    def send_json(self, data, status=200):
        body = json.dumps(data).encode("utf-8")
        self.send_response(status)
        self.send_cors_headers()
        self.send_header("Content-Type", "application/json")
        self.send_header("Content-Length", str(len(body)))
        self.end_headers()
        self.wfile.write(body)

    def send_cors_headers(self):
        self.send_header("Access-Control-Allow-Origin", "*")
        self.send_header("Access-Control-Allow-Methods", "GET, POST, OPTIONS")
        self.send_header("Access-Control-Allow-Headers", "Content-Type")

    def log_message(self, format, *args):
        print("%s - %s" % (self.address_string(), format % args))


def normalize_messages(messages, fallback_message):
    chat_messages = [
        {
            "role": "system",
            "content": "You are a helpful, concise assistant running locally through Ollama.",
        }
    ]

    for message in messages:
        role = message.get("role")
        content = message.get("content", "").strip()

        if role in ("user", "assistant") and content:
            chat_messages.append({"role": role, "content": content})

    if not any(message["role"] == "user" for message in chat_messages):
        chat_messages.append({"role": "user", "content": fallback_message})

    return chat_messages[-20:]


def call_ollama(path, payload=None, method="POST"):
    url = f"{OLLAMA_HOST}{path}"
    data = None
    headers = {}

    if payload is not None:
        data = json.dumps(payload).encode("utf-8")
        headers["Content-Type"] = "application/json"

    request = Request(url, data=data, headers=headers, method=method)

    try:
        with urlopen(request, timeout=120) as response:
            return json.loads(response.read().decode("utf-8"))
    except HTTPError as error:
        detail = error.read().decode("utf-8")
        raise RuntimeError(f"Ollama request failed: {detail}") from error
    except URLError as error:
        raise RuntimeError(
            "Could not reach Ollama. Start Ollama and confirm it is listening on "
            f"{OLLAMA_HOST}."
        ) from error
    except TimeoutError as error:
        raise RuntimeError("Ollama took too long to respond.") from error


if __name__ == "__main__":
    server = ThreadingHTTPServer(("0.0.0.0", PORT), ChatHandler)
    print(f"Python backend running on http://localhost:{PORT}")
    print(f"Using Ollama at {OLLAMA_HOST} with default model {DEFAULT_MODEL}")
    server.serve_forever()
