import { useState } from "react";
import axios from "axios";

function UserForm({ onUserAdded }) {
  const [name, setName] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();

    axios.post("http://localhost:5000/users", { name })
      .then(() => {
        setName("");
        onUserAdded();
      });
  };

  return (
    <form onSubmit={handleSubmit}>
      <input 
        type="text"
        value={name}
        onChange={(e) => setName(e.target.value)}
        placeholder="Enter user name"
      />
      <button type="submit">Add User</button>
    </form>
  );
}

export default UserForm;
