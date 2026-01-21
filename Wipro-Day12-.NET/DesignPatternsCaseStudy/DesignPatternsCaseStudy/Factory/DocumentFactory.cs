using DesignPatternsCaseStudy.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy.Factory
{
    // Factory class responsible for creating document objects
    public class DocumentFactory
    {
        // Method that returns document object based on input
        public static IDocument CreateDocument(string type)
        {
            // Check if document type is PDF
            if (type == "PDF")
                return new PdfDocument();   // Create PDF document

            // Check if document type is WORD
            else if (type == "WORD")
                return new WordDocument(); // Create Word document

            // Throw error if invalid type is provided
            else
                throw new ArgumentException("Invalid document type");
        }
    }
}
