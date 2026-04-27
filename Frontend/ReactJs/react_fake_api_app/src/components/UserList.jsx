import UserCard from './UserCard';

export default function UserList({ users }) {
  return (
    <section>
      <h3 className="section-title">Users from Fake API</h3>
      <div className="grid">
        {users.map((user) => (
          <UserCard key={user.id} user={user} />
        ))}
      </div>
    </section>
  );
}
