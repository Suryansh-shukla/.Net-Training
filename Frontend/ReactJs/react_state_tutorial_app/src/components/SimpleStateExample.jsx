import { useState } from "react";

export default function SimpleStateExample() {
  // A very simple state variable.
  // count stores the current number.
  // setCount updates the number.
  const [count, setCount] = useState(0);

  return (
    <section className="section">
      <h2>1. Simple Example - Counter using state()</h2>
      <p>
        This example shows the most basic use of state in React. When you click the
        button, the state changes and React automatically updates the UI.
      </p>

      <div className="grid">
        <div className="card">
          <h3>Live Example</h3>
          <p>Current Count: <strong>{count}</strong></p>

          {/* Increase the value by 1 */}
          <button onClick={() => setCount(count + 1)}>Increase</button>

          {/* Decrease the value by 1 */}
          <button className="secondary" onClick={() => setCount(count - 1)}>
            Decrease
          </button>

          {/* Reset back to 0 */}
          <button onClick={() => setCount(0)}>Reset</button>
        </div>

        <div className="card">
          <h3>Code Explanation</h3>
          <div className="code">{`const [count, setCount] = useState(0);

// Increase
setCount(count + 1);

// Decrease
setCount(count - 1);

// Reset
setCount(0);`}</div>
          <p className="small-note">
            This is ideal for teaching the core idea: state stores changing data.
          </p>
        </div>
      </div>
    </section>
  );
}
