const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const cors = require("cors");

const app = express();
const server = http.createServer(app);

const io = new Server(server, {
  cors: { origin: "*" },
});

app.use(cors());
app.use(express.json());

let tasks = [];

io.on("connection", (socket) => {
  console.log("User connected");

  socket.emit("loadTasks", tasks);

  socket.on("addTask", (task) => {
    tasks.push(task);
    io.emit("taskUpdated", tasks);
  });

  socket.on("deleteTask", (id) => {
    tasks = tasks.filter(task => task.id !== id);
    io.emit("taskUpdated", tasks);
  });
});

server.listen(5000, () => {
  console.log("Server running on port 5000");
});
