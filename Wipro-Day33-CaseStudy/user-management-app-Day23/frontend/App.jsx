import { useState } from "react";
import UserList from "./UserList";
import UserForm from "./UserForm";

function App() {
  const [refresh, setRefresh] = useState(false);

  const handleUserAdded = () => {
    setRefresh(!refresh);
  };

  return (
    <div>
      <h1>User Management System</h1>
      <UserForm onUserAdded={handleUserAdded} />
      <UserList refresh={refresh} />
    </div>
  );
}

export default App;
