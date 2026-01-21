using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Speech.Synthesis;//for text to speech
namespace DemoTexttospeechConverterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //s1 add reference to system.speech
            //s2 import system.speech.synthesis namespace
            //s3 create a speech symbol obj and call speak method

            // Optional: print current voice to confirm
            //Console.WriteLine("Using voice: " + synth.Voice.Name);

            SpeechSynthesizer synth = new SpeechSynthesizer();
            
            //change voice
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            //for pace
            synth.Rate = 5; // -10 = slowest, +10 = fastest

            //volume not greater than 100
            synth.Volume = 90;
            synth.Speak("Hello I am Mounika, welcome to my world how are u");

            

        }
    }
}
