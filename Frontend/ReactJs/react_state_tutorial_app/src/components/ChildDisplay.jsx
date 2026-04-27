export default function ChildDisplay({ sharedMessage }) {
  return (
    <div className="card">
      <h3>Child Component 2 - Display</h3>
      <p>
        This child component receives the shared data from the parent and displays it.
      </p>
      <p><strong>Shared Message:</strong> {sharedMessage}</p>
    </div>
  );
}
