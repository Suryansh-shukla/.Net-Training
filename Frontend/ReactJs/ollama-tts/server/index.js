const express = require("express");
const cors = require("cors");

const app = express();
app.use(cors());
app.use(express.json());

app.post("/generate", async (req, res) => {
  const { prompt } = req.body;

  try {
    const response = await fetch("http://localhost:11434/api/generate", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        model: "llama3",
        prompt: prompt,
        stream: false,
      }),
    });

    const data = await response.json();
    res.json({ text: data.response });
  } catch (err) {
    res.status(500).json({ error: "Ollama error" });
  }
});

app.listen(5000, () => console.log("Server running on port 5000"));