// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(String[] args)
        {
            // Step 1: Create a Stack that can hold integer values
            Stack<int> stack = new Stack<int>();

            // Step 2: Push some values onto the stack
            // Push() is used instead of Add() because Stack follows LIFO (Last In First Out)
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Step 3: Pop a value from the stack and display it
            // Pop() removes and returns the top-most element
            int poppedValue = stack.Pop();
            Console.WriteLine("Popped Value: " + poppedValue);

            // Step 4: Peek at the top value of the stack without removing it
            // Peek() only reads the top element
            int topValue = stack.Peek();
            Console.WriteLine("Top Value: " + topValue);

            // Step 5: Check if the stack contains a specific value
            // Contains() returns true if the value exists
            bool contains20 = stack.Contains(20);
            Console.WriteLine("Stack contains 20: " + contains20);

            // Step 6: Display the current count of items in the stack
            // Count property gives number of elements
            int count = stack.Count;
            Console.WriteLine("Current Count: " + count);

            // Step 7: Clear all items from the stack
            
            stack.Clear();

            // Display count after clearing the stack
            Console.WriteLine("Stack cleared. Current Count after clearing: " + stack.Count);
          //  Console.WriteLine("Stack cleared. Current Count after clearing: " + stack.Count);

        }


    }
}

