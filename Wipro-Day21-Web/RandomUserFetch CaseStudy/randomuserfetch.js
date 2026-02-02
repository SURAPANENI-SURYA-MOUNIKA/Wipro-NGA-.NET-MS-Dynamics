// Add event listener to button
document.getElementById("fetchBtn").addEventListener("click", getRandomUser);

function getRandomUser() {
    fetch("https://randomuser.me/api/")
        .then(response => response.json())
        .then(data => {
            const user = data.results[0];

            const fullName = user.name.first + " " + user.name.last;
            const email = user.email;
            const picture = user.picture.large;

            document.getElementById("userInfo").innerHTML = `
                <img src="${picture}" alt="Profile Picture">
                <h3>${fullName}</h3>
                <p>Email: ${email}</p>
            `;
        })
        .catch(error => {
            document.getElementById("userInfo").innerHTML =
                "<p>Error fetching user data</p>";
            console.error(error);
        });
}
