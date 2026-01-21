// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //for file handling
namespace DemoOnFileHandling
{


    internal class Program
    {
        static void Main(String[] args)
        {
            //creating a file using File.Creat() method
            string filePath = "filedemo.txt";
            using (FileStream fs=File.Create(filePath))
            {
                if(File.Exists(filePath))
                {
                    Console.WriteLine("Created file succeesfully:" + filePath);
                }
                else
                {
                    Console.WriteLine("Failed to create file");
                }
            }
           using(StreamWriter sw=new StreamWriter(filePath))
            {
                sw.WriteLine("helloooooo this is demo file ");
                sw.WriteLine("i created this file haiiii ");
            }
            //reading from the file using StreamReader class
            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("here are the file content ");
                Console.WriteLine(content);
            }
            //deleting the file using file.delete()
            File.Delete(filePath);
            if(!File.Exists(filePath))
            {
                Console.WriteLine("File deeleted successfully:" + filePath);
            }


        }
    }
}