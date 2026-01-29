// US-13: JavaScript Logic
// US-14: DOM Manipulation

document.getElementById("contactForm").addEventListener("submit", function (e) {
    e.preventDefault();

    if (!this.checkValidity()) {
        this.classList.add("was-validated");
        return;
    }

    alert("Form Submitted Successfully");
    this.reset();
});

// US-15: Fetch API with error handling
document.getElementById("loadUsers").addEventListener("click", () => {
    fetch("https://jsonplaceholder.typicode.com/users")
        .then(response => {
            if (!response.ok) {
                throw new Error("Fetch failed");
            }
            return response.json();
        })
        .then(data => {
            const list = document.getElementById("userList");
            list.innerHTML = "";
            data.slice(0, 5).forEach(user => {
                const li = document.createElement("li");
                li.textContent = user.name;
                list.appendChild(li);
            });
        })
        .catch(() => {
            alert("Error loading users");
        });
});
