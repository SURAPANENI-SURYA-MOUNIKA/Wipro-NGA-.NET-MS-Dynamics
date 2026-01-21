using DesignPatternsCaseStudy.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy.Observer
{
    // WeatherDisplay acts as Observer
    public class WeatherDisplay : IObserver
    {
        // Name of the display
        private string displayName;

        // Constructor to set display name
        public WeatherDisplay(string name)
        {
            displayName = name;
        }

        // Method called when WeatherStation updates data
        public void Update(float temperature)
        {
            // Display updated temperature
            Console.WriteLine($"{displayName} received temperature update: {temperature}°C");
        }
    }
}
