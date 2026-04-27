import { useState } from "react";
import ChildInput from "./ChildInput";
import ChildDisplay from "./ChildDisplay";

export default function DataSharingExample() {
  // This state lives in the parent.
  // Both child components use this same state.
  const [sharedMessage, setSharedMessage] = useState("Hello from parent state");

  return (
    <section className="section">
      <h2>4. How state data can be shared from one component to another</h2>
      <p>
        In React, one component does not directly send its own state to another sibling
        component. The usual pattern is called <strong>lifting state up</strong>.
        You move the shared state to the common parent, then pass the value and setter
        as props to child components.
      </p>

      <div className="grid">
        <div>
          <ChildInput
            sharedMessage={sharedMessage}
            setSharedMessage={setSharedMessage}
          />
        </div>
        <div>
          <ChildDisplay sharedMessage={sharedMessage} />
        </div>
      </div>

      <div className="card" style={{ marginTop: "18px" }}>
        <h3>Flow Explanation</h3>
        <div className="code">{`Parent Component
  ├── holds the state
  ├── passes value to Child A
  ├── passes value to Child B
  └── passes setter to Child A for updating the shared state`}</div>
      </div>
    </section>
  );
}
