export default function UserCard({ user }) {
  return (
    <article className="card">
      <div className="card-header">
        <h4>{user.name}</h4>
        <span className="pill">@{user.username}</span>
      </div>

      <p><strong>Email:</strong> {user.email}</p>
      <p><strong>Phone:</strong> {user.phone}</p>
      <p><strong>Website:</strong> {user.website}</p>
      <p><strong>Company:</strong> {user.company?.name}</p>
      <p><strong>Address:</strong> {user.address?.street}, {user.address?.city}</p>
    </article>
  );
}
