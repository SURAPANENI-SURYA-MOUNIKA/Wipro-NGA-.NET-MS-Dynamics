// See https://aka.ms/new-console-template for more information

using System;

internal class Program
{
    //counting sort
    static void CountingSort(int[] arr, int maxValue)
    {
        int[] count = new int[maxValue + 1];

        // count occurrences
        foreach (int num in arr)
        {
            count[num]++;   
        }

        // rebuild array
        int index = 0;
        for (int i = 0; i <= maxValue; i++) 
        {
            while (count[i] > 0)
            {
                arr[index++] = i;
                count[i]--;
            }
        }
    }

    // radix sort
    static void RadixSort(int[] arr)
    {
        int max = GetMax(arr);

        for (int exp = 1; max / exp > 0; exp *= 10) 
        {
            CountingSortByDigit(arr, exp);
        }
    }

    // get maximum value
    static int GetMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max; 
    }

    // counting sort by digit
    static void CountingSortByDigit(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10];

        // count digit occurrences
        for (int i = 0; i < n; i++)
        {
            int digit = (arr[i] / exp) % 10;
            count[digit]++;
        }

        // cumulative count
        for (int i = 1; i < 10; i++) 
        {
            count[i] += count[i - 1];
        }

        // build output array
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (arr[i] / exp) % 10;
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        // copy back
        for (int i = 0; i < n; i++) 
        {
            arr[i] = output[i];
        }
    }

    //print method
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

   
    static void Main(string[] args)
    {
        int[] marks = { 56,34,34,76,34,25,67 };
        Console.WriteLine("Original marks:");
        PrintArray(marks);
        Console.WriteLine();
        CountingSort(marks, 100);
        Console.WriteLine("Counting sort:");
        PrintArray(marks);
        Console.WriteLine();
        int[] regNumber = { 10245, 95581, 2558, 5484, 15488 };
        Console.WriteLine("Original registration numbers:");
        PrintArray(regNumber);
        Console.WriteLine();
        RadixSort(regNumber);
        Console.WriteLine("Sorted registration numbers:");
        PrintArray(regNumber);
    }
}
