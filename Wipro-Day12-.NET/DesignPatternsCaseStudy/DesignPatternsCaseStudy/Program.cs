using DesignPatternsCaseStudy.Factory;
using DesignPatternsCaseStudy.Observer;
using DesignPatternsCaseStudy.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy
{
    class Program
    {
        static void Main()
        {
            // Get the single Logger instance
            var logger = Logger.Instance;

            // Write log message
            logger.Log("Application Started");

            // Create PDF document using Factory
            IDocument pdf = DocumentFactory.CreateDocument("PDF");

            // Open PDF document
            pdf.Open();

            // Create Word document using Factory
            IDocument word = DocumentFactory.CreateDocument("WORD");

            // Open Word document
            word.Open();

            // Create WeatherStation (Subject)
            WeatherStation station = new WeatherStation();

            // Create observers
            WeatherDisplay display1 = new WeatherDisplay("Display 1");
            WeatherDisplay display2 = new WeatherDisplay("Display 2");

            // Register observers
            station.Register(display1);
            station.Register(display2);

            // Update temperature (observers get notified)
            station.SetTemperature(30.5f);
        }
    }
}