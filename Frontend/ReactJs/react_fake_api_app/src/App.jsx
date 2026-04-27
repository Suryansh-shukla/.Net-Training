import { useEffect, useState } from 'react';
import Header from './components/Header';
import UserList from './components/UserList';
import StatusMessage from './components/StatusMessage';

export default function App() {
  const [users, setUsers] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState('');

  useEffect(() => {
    const fetchUsers = async () => {
      try {
        setIsLoading(true);
        setError('');

        const response = await fetch('https://jsonplaceholder.typicode.com/users');

        if (!response.ok) {
          throw new Error('Failed to fetch users from the API.');
        }

        const data = await response.json();
        setUsers(data);
      } catch (err) {
        setError(err.message || 'Something went wrong.');
      } finally {
        setIsLoading(false);
      }
    };

    fetchUsers();
  }, []);

  return (
    <div className="app-shell">
      <Header />

      <main className="container">
        <section className="intro-card">
          <h2>Sample React App using Fake API</h2>
          <p>
            This app fetches user data from JSONPlaceholder and displays the
            records using reusable React components.
          </p>
        </section>

        {isLoading && <StatusMessage type="loading" message="Loading users..." />}
        {error && <StatusMessage type="error" message={error} />}
        {!isLoading && !error && <UserList users={users} />}
      </main>
    </div>
  );
}
