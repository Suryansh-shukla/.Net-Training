# Ollama React Chatbot

This project uses a React frontend and a Python backend that calls your local Ollama server.

## Installed project dependencies

Frontend dependencies are already installed in the root `package.json`:

- React 19
- React DOM 19
- React Scripts 5
- Testing Library packages
- Web Vitals

The old `server` folder also has Node/Express dependencies, but the chatbot backend is now Python in `server/app.py`.

## Prerequisites

Install and run Ollama, then pull a model:

```bash
ollama pull llama3
```

Keep Ollama running on its default URL:

```bash
ollama serve
```

## Run the app

Open one terminal for the Python backend:

```bash
npm run start:backend
```

Open a second terminal for the React frontend:

```bash
npm run start:frontend
```

Then open:

```text
http://localhost:3000
```

## Backend settings

The backend uses these defaults:

- Backend URL: `http://localhost:5000`
- Ollama URL: `http://localhost:11434`
- Default model: `llama3`

You can change the model from the UI, or set an environment variable before starting the backend:

```bash
set OLLAMA_MODEL=mistral
npm run start:backend
```

To point React at a different backend URL:

```bash
set REACT_APP_API_URL=http://localhost:5000
npm run start:frontend
```
