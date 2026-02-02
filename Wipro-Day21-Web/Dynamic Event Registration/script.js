//STEP 2: Access DOM Objects (Create references to DOM elements)
//STEP 3: Event Data (JavaScript Object)
//STEP 4: Display Events Dynamically (Add Elements)
//STEP 5: Handle Event Selection (Modify Content)
//STEP 6: Register for Event (Modify DOM Content)
//STEP 7: Unregister from Event (Remove / Modify)
//STEP 8: Add New Event Dynamically (Create + Append)
//STEP 9: Prevent Errors (Client-Side Validation)

// STEP 2: Access DOM Objects (Create references to DOM elements)
const eventList = document.getElementById("eventList");
const eventTitle = document.getElementById("eventTitle");
const eventDesc = document.getElementById("eventDesc");
const countSpan = document.getElementById("count");
const registerBtn = document.getElementById("registerBtn");
const unregisterBtn = document.getElementById("unregisterBtn");
const addEventBtn = document.getElementById("addEventBtn");

// STEP 3: Event Data (JavaScript Object)
let events = [
    { id: 1, title: "Hackathon", desc: "Hackathon for all colleges", count: 0 },
    { id: 2, title: "Innovation Club", desc: "Generate innovative ideas", count: 0 },
    { id: 3, title: "AI Workshop", desc: "Learn Ai", count: 0 }
];

let selectedEvent = null;

// STEP 4: Display Events Dynamically (Add Elements)
function displayEvents() {
    eventList.innerHTML = "";

    events.forEach(event => {
        const li = document.createElement("li");
        li.textContent = event.title;

        li.addEventListener("click", () => selectEvent(event, li));

        eventList.appendChild(li);
    });
}

displayEvents();

// STEP 5: Handle Event Selection (Modify Content)
function selectEvent(event, element) {
    selectedEvent = event;

    document.querySelectorAll("#eventList li").forEach(li => {
        li.classList.remove("selected");
    });

    element.classList.add("selected");

    eventTitle.textContent = event.title;
    eventDesc.textContent = event.desc;
    countSpan.textContent = event.count;
}

// STEP 6: Register for Event (Modify DOM Content)
registerBtn.addEventListener("click", () => {
    if (!selectedEvent) {
        alert("Please select an event first");
        return;
    }

    selectedEvent.count++;
    countSpan.textContent = selectedEvent.count;
});

// STEP 7: Unregister from Event (Remove / Modify)
unregisterBtn.addEventListener("click", () => {
    if (!selectedEvent) {
        alert("Please select an event first");
        return;
    }

    if (selectedEvent.count > 0) {
        selectedEvent.count--;
        countSpan.textContent = selectedEvent.count;
    }
});

// STEP 8: Add New Event Dynamically (Create + Append)
addEventBtn.addEventListener("click", () => {

    const newEvent = {
        id: events.length + 1,
        title: "New Event " + (events.length + 1),
        desc: "This is a newly added event",
        count: 0
    };

    events.push(newEvent);
    displayEvents();
});

