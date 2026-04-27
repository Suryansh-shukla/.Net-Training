import UserDetails from "./UserDetails";

export default function SendDataExample() {
  // Data in parent component.
  const user = {
    name: "Gopinath",
    role: "React Learner",
    city: "Bengaluru"
  };

  return (
    <section className="section">
      <h2>5. How to send data from one component to another component</h2>
      <p>
        The most common way to send data from one component to another is by using
        <strong> props</strong>. The parent component sends data to the child component.
      </p>

      <div className="grid">
        <div className="card">
          <h3>Parent Component</h3>
          <p>
            This component holds the user object and sends each value to the child.
          </p>
          <div className="code">{`const user = {
  name: "Gopinath",
  role: "React Learner",
  city: "Bengaluru"
};

<UserDetails
  name={user.name}
  role={user.role}
  city={user.city}
/>`}</div>
        </div>

        <div>
          <UserDetails
            name={user.name}
            role={user.role}
            city={user.city}
          />
        </div>
      </div>
    </section>
  );
}
