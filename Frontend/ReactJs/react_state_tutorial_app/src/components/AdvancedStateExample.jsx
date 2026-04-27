import { useState } from "react";

export default function AdvancedStateExample() {
  // State for the text box.
  const [taskText, setTaskText] = useState("");

  // State for a list of tasks.
  const [tasks, setTasks] = useState([
    { id: 1, title: "Learn useState", done: true },
    { id: 2, title: "Build a sample React app", done: false }
  ]);

  function addTask() {
    if (!taskText.trim()) return;

    // Functional update is useful when the new state depends on the old state.
    setTasks((prevTasks) => [
      ...prevTasks,
      {
        id: Date.now(),
        title: taskText,
        done: false
      }
    ]);

    setTaskText("");
  }

  function toggleTask(taskId) {
    setTasks((prevTasks) =>
      prevTasks.map((task) =>
        task.id === taskId ? { ...task, done: !task.done } : task
      )
    );
  }

  function deleteTask(taskId) {
    setTasks((prevTasks) => prevTasks.filter((task) => task.id !== taskId));
  }

  const completedCount = tasks.filter((task) => task.done).length;

  return (
    <section className="section">
      <h2>3. Advanced Example - Task manager with array state</h2>
      <p>
        This example demonstrates array state, object updates inside an array,
        functional updates, conditional UI, and derived values.
      </p>

      <div className="grid">
        <div className="card">
          <h3>Live Example</h3>
          <input
            type="text"
            placeholder="Enter a new task"
            value={taskText}
            onChange={(e) => setTaskText(e.target.value)}
          />
          <button onClick={addTask}>Add Task</button>

          <p>
            <strong>Total Tasks:</strong> {tasks.length} |{" "}
            <strong>Completed:</strong> {completedCount}
          </p>

          {tasks.map((task) => (
            <div key={task.id} className={`todo-item ${task.done ? "done" : ""}`}>
              <span className={task.done ? "done-text" : ""}>{task.title}</span>
              <div>
                <button onClick={() => toggleTask(task.id)}>
                  {task.done ? "Undo" : "Done"}
                </button>
                <button className="secondary" onClick={() => deleteTask(task.id)}>
                  Delete
                </button>
              </div>
            </div>
          ))}
        </div>

        <div className="card">
          <h3>Key Concepts Used</h3>
          <div className="code">{`// Add item
setTasks((prevTasks) => [...prevTasks, newTask]);

// Toggle one item
setTasks((prevTasks) =>
  prevTasks.map((task) =>
    task.id === taskId ? { ...task, done: !task.done } : task
  )
);

// Delete item
setTasks((prevTasks) =>
  prevTasks.filter((task) => task.id !== taskId)
);`}</div>
          <p className="small-note">
            This is a strong real-world example because it combines arrays, objects,
            mapping, filtering, and functional updates.
          </p>
        </div>
      </div>
    </section>
  );
}
