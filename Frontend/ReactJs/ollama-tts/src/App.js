import { useMemo, useRef, useState } from "react";
import "./App.css";

const API_BASE_URL = process.env.REACT_APP_API_URL || "http://localhost:5000";

const starterMessages = [
  {
    role: "assistant",
    content:
      "Hi! I am connected to your local Ollama server. Ask me anything to get started.",
  },
];

function App() {
  const [messages, setMessages] = useState(starterMessages);
  const [input, setInput] = useState("");
  const [model, setModel] = useState("llama3");
  const [isSending, setIsSending] = useState(false);
  const [error, setError] = useState("");
  const inputRef = useRef(null);

  const canSend = useMemo(
    () => input.trim().length > 0 && !isSending,
    [input, isSending]
  );

  async function sendMessage(event) {
    event.preventDefault();

    const userMessage = input.trim();
    if (!userMessage || isSending) {
      return;
    }

    const nextMessages = [...messages, { role: "user", content: userMessage }];
    setMessages(nextMessages);
    setInput("");
    setError("");
    setIsSending(true);

    try {
      const response = await fetch(`${API_BASE_URL}/api/chat`, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          model,
          message: userMessage,
          messages: nextMessages,
        }),
      });

      const data = await response.json();

      if (!response.ok) {
        throw new Error(data.error || "The backend could not complete the request.");
      }

      setMessages((currentMessages) => [
        ...currentMessages,
        { role: "assistant", content: data.reply },
      ]);
    } catch (requestError) {
      setError(requestError.message);
      setMessages((currentMessages) => [
        ...currentMessages,
        {
          role: "assistant",
          content:
            "I could not reach Ollama. Make sure Ollama is running and the selected model is installed.",
        },
      ]);
    } finally {
      setIsSending(false);
      inputRef.current?.focus();
    }
  }

  function clearChat() {
    setMessages(starterMessages);
    setError("");
    inputRef.current?.focus();
  }

  return (
    <main className="app-shell">
      <section className="chat-panel" aria-label="Ollama chatbot">
        <header className="chat-header">
          <div>
            <p className="eyebrow">Local AI chat</p>
            <h1>Ollama Chatbot</h1>
          </div>

          <div className="model-controls">
            <label htmlFor="model">Model</label>
            <input
              id="model"
              value={model}
              onChange={(event) => setModel(event.target.value)}
              placeholder="llama3"
            />
            <button type="button" onClick={clearChat} className="secondary-button">
              Clear
            </button>
          </div>
        </header>

        <div className="message-list" aria-live="polite">
          {messages.map((message, index) => (
            <article
              className={`message ${message.role}`}
              key={`${message.role}-${index}`}
            >
              <span>{message.role === "user" ? "You" : "Ollama"}</span>
              <p>{message.content}</p>
            </article>
          ))}

          {isSending && (
            <article className="message assistant">
              <span>Ollama</span>
              <p>Thinking...</p>
            </article>
          )}
        </div>

        {error && <p className="error-message">{error}</p>}

        <form className="composer" onSubmit={sendMessage}>
          <textarea
            ref={inputRef}
            value={input}
            onChange={(event) => setInput(event.target.value)}
            onKeyDown={(event) => {
              if (event.key === "Enter" && !event.shiftKey) {
                sendMessage(event);
              }
            }}
            placeholder="Type your message..."
            rows="3"
          />
          <button type="submit" disabled={!canSend}>
            {isSending ? "Sending" : "Send"}
          </button>
        </form>
      </section>
    </main>
  );
}

export default App;
