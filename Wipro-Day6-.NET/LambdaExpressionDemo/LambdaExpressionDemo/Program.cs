// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaExpressionDemo
{

    class Program
    {
        static void Main()
        {
            // with the help of lambda expression we can write it in one line like
            Func<int, bool> IsEven = number => number % 2 == 0;

           // Console.WriteLine("Is 10 Even? : " + IsEven(10));
           // Console.WriteLine("Is 7 Even?  : " + IsEven(7));

            // In a collection if we want to implement lambda expression to find a number greater than 10
            List<int> numbers = new List<int> { 3, 5, 81, 45, 32, 15, 70 };

            // displaying elements of the list
            Console.WriteLine("\nElements in the list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Lambda expression there in C# 3.0
            int result = numbers.Find(n => n > 10);
            var evenNumber = numbers.Where(n => n % 2 == 0);//var is implicit type variable
            Console.WriteLine("list of even numbers");
            foreach(var iteam in evenNumber)
            {
                Console.WriteLine(iteam);
            }

            Console.WriteLine("\nHere is the first number greater than 10 in list implemented via lambda expression: " + result);
        }
    }
}