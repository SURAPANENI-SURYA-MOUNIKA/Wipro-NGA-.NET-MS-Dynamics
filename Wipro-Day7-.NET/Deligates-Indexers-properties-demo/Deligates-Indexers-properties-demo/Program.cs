// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    /*indexers:it allows an obj to accessed like an array using [] ex: obj[i]
   Attributes:used for adding metadata- to code elements as classess,methods,
   properties,parameters
   this metadata is read at run time using reflection 
    */
   /
    [Obsolete("use new method instead")]
        static void OldMethodforDisplayingData()
    {
        Console.WriteLine("very old method for displaying info");
    }
   
    static void Main(string[] args)
    {
        StudentMarks myStudent = new StudentMarks();
        myStudent[0] = 90;
        myStudent[1] = 34;
        myStudent[2] = 54;
        myStudent[3] = 98;
        Console.WriteLine("student marks");
            Console.WriteLine(myStudent[0]);
        Console.WriteLine(myStudent[1]);
        Console.WriteLine(myStudent[2]);
        Console.WriteLine(myStudent[3]);

    }
}
class StudentMarks
{
    private int[] marks = new int[5];
    //indexer
    public int this[int index]
    {
        get
        {
            return marks[index];
        }
        set { marks[index] = value; }
    }
}