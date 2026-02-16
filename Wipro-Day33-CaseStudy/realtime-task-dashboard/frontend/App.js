import React, { useState, useEffect } from "react";
import io from "socket.io-client";

const socket = io("http://localhost:5000");

function App() {
  const [tasks, setTasks] = useState([]);
  const [newTask, setNewTask] = useState("");

  useEffect(() => {
    socket.on("loadTasks", (loadedTasks) => {
      setTasks(loadedTasks);
    });

    socket.on("taskUpdated", (updatedTasks) => {
      setTasks(updatedTasks);
    });

    return () => socket.disconnect();
  }, []);

  const addTask = () => {
    if (newTask.trim() !== "") {
      socket.emit("addTask", {
        id: Date.now(),
        title: newTask,
      });
      setNewTask("");
    }
  };

  const deleteTask = (id) => {
    socket.emit("deleteTask", id);
  };

  return (
    <div style={{ padding: "20px" }}>
      <h1>Real-Time Task Dashboard 🚀</h1>

      <input
        type="text"
        value={newTask}
        onChange={(e) => setNewTask(e.target.value)}
        placeholder="Enter Task"
      />
      <button onClick={addTask}>Add Task</button>

      <ul>
        {tasks.map((task) => (
          <li key={task.id}>
            {task.title}
            <button onClick={() => deleteTask(task.id)}>❌</button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
