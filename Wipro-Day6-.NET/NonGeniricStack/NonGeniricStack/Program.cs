// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a NON-GENERIC Stack
        // This stack can store values of ANY data type (int, string, object, etc.)
        Stack stack = new Stack();

        // Step 2: Push elements into the stack
        // Push() adds elements to the top of the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push("mounika");

        // Step 3: Pop operation
        // Pop() removes and returns the top element of the stack
        object poppedValue = stack.Pop();
        Console.WriteLine("Popped Value: " + poppedValue);

        // Step 4: Peek operation
        // Peek() returns the top element WITHOUT removing it
        object topValue = stack.Peek();
        Console.WriteLine("Top Value: " + topValue);

        // Step 5: Contains operation
        // Contains() checks whether a specific value exists in the stack
        bool contains20 = stack.Contains(20);
        Console.WriteLine("Stack contains 20: " + contains20);

        // Step 6: Count operation
        // Count property returns the total number of elements in the stack
        int count = stack.Count;
        Console.WriteLine("Current Count: " + count);

        // Step 7: Clear operation
        // Clear() removes all elements from the stack
        stack.Clear();

        // Display count after clearing the stack
        Console.WriteLine("Stack cleared. Count after clearing: " + stack.Count);
    }
}

