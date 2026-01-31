const tableHead = document.getElementById("tableHead");
const tableBody = document.getElementById("tableBody");

function clearTable() {
  tableHead.innerHTML = "";
  tableBody.innerHTML = "";
}

// TODOS
function loadTodos() {
  clearTable();

  tableHead.innerHTML = `
    <tr>
      <th>ID</th>
      <th>Title</th>
      <th>Completed</th>
    </tr>
  `;

  fetch("https://jsonplaceholder.typicode.com/todos")
    .then(res => res.json())
    .then(data => {
      data.slice(0, 20).forEach(todo => {
        tableBody.innerHTML += `
          <tr>
            <td>${todo.id}</td>
            <td>${todo.title}</td>
            <td>${todo.completed}</td>
          </tr>
        `;
      });
    })
    .catch(err => console.error(err));
}

// COMMENTS
function loadComments() {
  clearTable();

  tableHead.innerHTML = `
    <tr>
      <th>ID</th>
      <th>Name</th>
      <th>Email</th>
      <th>Comment</th>
    </tr>
  `;

  fetch("https://jsonplaceholder.typicode.com/comments")
    .then(res => res.json())
    .then(data => {
      data.slice(0, 20).forEach(comment => {
        tableBody.innerHTML += `
          <tr>
            <td>${comment.id}</td>
            <td>${comment.name}</td>
            <td>${comment.email}</td>
            <td>${comment.body}</td>
          </tr>
        `;
      });
    })
    .catch(err => console.error(err));
}

// USERS
function loadUsers() {
  clearTable();

  tableHead.innerHTML = `
    <tr>
      <th>ID</th>
      <th>Name</th>
      <th>Email</th>
      <th>City</th>
    </tr>
  `;

  fetch("https://jsonplaceholder.typicode.com/users")
    .then(res => res.json())
    .then(data => {
      data.forEach(user => {
        tableBody.innerHTML += `
          <tr>
            <td>${user.id}</td>
            <td>${user.name}</td>
            <td>${user.email}</td>
            <td>${user.address.city}</td>
          </tr>
        `;
      });
    })
    .catch(err => console.error(err));
}
