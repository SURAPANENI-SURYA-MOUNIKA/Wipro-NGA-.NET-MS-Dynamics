using DesignPatternsCaseStudy.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy.Factory
{
    
    // Word document class
    public class WordDocument : IDocument
    {
        // Implementation of Open method for Word
        public void Open()
        {
            Console.WriteLine("Opening Word Document");
        }
    }
}
