// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Student Result Program");

// Call main function
mainFunction();

// function to calculate total marks
int calculateTotal(int m1, int m2, int m3)
{
    return m1 + m2 + m3;
}

// function to calculate average
double calculateAverage(int totalmarks, int noofsub = 3)
{
    return (double)totalmarks / noofsub;
}

// function to check result
string checkResult(double averageMarks, double passmarks = 40.0)
{
    if (averageMarks >= passmarks)
    {
        return "Pass";
    }
    else
    {
        return "Fail";
    }
}

// main function
void mainFunction()
{
    // Marks given directly
    int m1 = 75;
    int m2 = 60;
    int m3 = 45;

    int total = calculateTotal(m1, m2, m3);
    double average = calculateAverage(total);
    string result = checkResult(average);

    Console.WriteLine("\n----- Result -----");
    Console.WriteLine("Subject 1: " + m1);
    Console.WriteLine("Subject 2: " + m2);
    Console.WriteLine("Subject 3: " + m3);
    Console.WriteLine("Total Marks: " + total);
    Console.WriteLine("Average Marks: " + average);
    Console.WriteLine("Result: " + result);
}





// See https://aka.ms/new-console-template for more information
Console.WriteLine("Student Result Program");

// Call main function
mainFunction1();

// function to calculate total marks
int calculateTotal1(int m1, int m2, int m3)
{
    return m1 + m2 + m3;
}

// function to calculate average
double calculateAverage1(int totalmarks, int noofsub = 3)
{
    return (double)totalmarks / noofsub;
}

// function to check result
string checkResult1(double averageMarks, double passmarks = 40.0)
{
    if (averageMarks >= passmarks)
    {
        return "Pass";
    }
    else
    {
        return "Fail";
    }
}

// main function
void mainFunction1()
{
    // Taking input and using Convert
    Console.Write("Enter marks for Subject 1: ");
    int m1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter marks for Subject 2: ");
    int m2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter marks for Subject 3: ");
    int m3 = Convert.ToInt32(Console.ReadLine());

    int total = calculateTotal(m1, m2, m3);
    double average = calculateAverage(total);
    string result = checkResult(average);

    Console.WriteLine("\n----- Result -----");
    Console.WriteLine("Subject 1: " + m1);
    Console.WriteLine("Subject 2: " + m2);
    Console.WriteLine("Subject 3: " + m3);
    Console.WriteLine("Total Marks: " + total);
    Console.WriteLine("Average Marks: " + average);
    Console.WriteLine("Result: " + result);
}
