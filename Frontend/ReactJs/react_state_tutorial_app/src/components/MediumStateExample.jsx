import { useState } from "react";

export default function MediumStateExample() {
  // State used for a small form.
  const [student, setStudent] = useState({
    name: "",
    course: "",
    city: ""
  });

  // Handle changes for all input fields using one function.
  function handleChange(event) {
    const { name, value } = event.target;

    // Copy existing object values and update only the changed property.
    setStudent((prevStudent) => ({
      ...prevStudent,
      [name]: value
    }));
  }

  return (
    <section className="section">
      <h2>2. Medium Example - Form with object state</h2>
      <p>
        This example shows how state can store an object. It is useful when multiple
        related values belong together, such as a student record or profile form.
      </p>

      <div className="grid">
        <div className="card">
          <h3>Live Example</h3>

          {/* Each input uses the same handleChange function */}
          <input
            type="text"
            name="name"
            placeholder="Enter student name"
            value={student.name}
            onChange={handleChange}
          />

          <input
            type="text"
            name="course"
            placeholder="Enter course name"
            value={student.course}
            onChange={handleChange}
          />

          <input
            type="text"
            name="city"
            placeholder="Enter city"
            value={student.city}
            onChange={handleChange}
          />

          <div className="user-card">
            <h4>Preview</h4>
            <p><strong>Name:</strong> {student.name || "Not entered"}</p>
            <p><strong>Course:</strong> {student.course || "Not entered"}</p>
            <p><strong>City:</strong> {student.city || "Not entered"}</p>
          </div>
        </div>

        <div className="card">
          <h3>Important Concept</h3>
          <div className="code">{`const [student, setStudent] = useState({
  name: "",
  course: "",
  city: ""
});

setStudent((prevStudent) => ({
  ...prevStudent,
  [name]: value
}));`}</div>
          <p className="small-note">
            We use the spread operator to keep old values and change only one field.
          </p>
        </div>
      </div>
    </section>
  );
}
