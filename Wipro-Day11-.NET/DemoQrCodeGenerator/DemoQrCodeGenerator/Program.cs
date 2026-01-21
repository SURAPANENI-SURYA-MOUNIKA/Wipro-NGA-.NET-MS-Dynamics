using System;
using QRCoder;
using System.IO;

namespace DemoQrCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            QRCodeData qrCodeData =
                qrGenerator.CreateQrCode(
                    "https://careers.wipro.com/content/Early-Careers/?locale=en_US",
                    QRCodeGenerator.ECCLevel.Q
                );

            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCode.GetGraphic(20);

            File.WriteAllBytes("Wipro_QR_Code.png", qrCodeBytes);

            Console.WriteLine("QR Code generated and saved as Wipro_QR_Code.png");
        }
    }
}

























/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
//using System.Drawing;
//using System.Drawing.Imaging;
using System.IO;

namespace DemoQrCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //s1steps for qr code via nuget pacakge installer
            //s2 Add using qr code 
            //3 code
            //create qr code 
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Create QR code data from a string
            QRCodeData qrCodeData =
                qrGenerator.CreateQrCode("https://careers.wipro.com/content/Early-Careers/?locale=en_US",
                QRCodeGenerator.ECCLevel.Q);

            // Create a QR code from the QR code data
            QRCode qrCode = new QRCode(qrCodeData);

            // Generate the QR code as a bitmap image
            var qrCodeImage = qrCode.GetGraphic(20); //after adding ref of System.Drawing.Common

            // Save the QR code image to a file
            qrCodeImage.Save("Wipro_QR_Code.png", System.Drawing.Imaging.ImageFormat.Png);

            Console.WriteLine("QR Code generated and saved as Wipro_QR_Code.png");

        }
    }
}
*/