// Function to convert text into speech
function convertToSpeech() {

    // Get text from textarea
    let text = document.getElementById("textInput").value;

    // Check if user entered text
    //trim remove spaces means prvent speaking empty text
    if (text.trim() === "") {
        alert("Please enter some text");
        return;
    }


    // Create a speech object
    let speech = new SpeechSynthesisUtterance();

    // Set the text to be spoken
    speech.text = text;

    //pace
    // 1 = normal, <1 = slow, >1 = fast
    speech.rate = 1;      

    // Volume 
    // Range: 0 (mute) to 1 (full volume)
    speech.volume = 10;    

    // Speak the text
    window.speechSynthesis.speak(speech);
}
