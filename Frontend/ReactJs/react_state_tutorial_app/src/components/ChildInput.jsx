export default function ChildInput({ sharedMessage, setSharedMessage }) {
  return (
    <div className="card">
      <h3>Child Component 1 - Input</h3>
      <p>
        This child component can update the parent state using the setter function
        passed from the parent.
      </p>

      <input
        type="text"
        value={sharedMessage}
        onChange={(e) => setSharedMessage(e.target.value)}
        placeholder="Type a shared message"
      />
    </div>
  );
}
