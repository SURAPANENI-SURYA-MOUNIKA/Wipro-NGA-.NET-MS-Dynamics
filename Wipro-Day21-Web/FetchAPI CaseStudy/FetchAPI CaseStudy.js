// API URL
const url = "https://dummy.restapiexample.com/api/v1/employees";

// Fetch employee data
fetch(url)
    .then(response => {
        // Check if response is successful
        if (!response.ok) {
            throw new Error("Network response was not OK");
        }
        return response.json();
    })
    .then(data => {
        // Display data in console
        console.log("Employee Data:");
        console.log(data);
    })
    .catch(error => {
        // Handle errors
        console.error("Error fetching data:", error);
    });
