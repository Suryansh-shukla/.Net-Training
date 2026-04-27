export default function UserDetails({ name, role, city }) {
  return (
    <div className="user-card">
      <h3>Child Component - UserDetails</h3>
      <p><strong>Name:</strong> {name}</p>
      <p><strong>Role:</strong> {role}</p>
      <p><strong>City:</strong> {city}</p>
    </div>
  );
}
