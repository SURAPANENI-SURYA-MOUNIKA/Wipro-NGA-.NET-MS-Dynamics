// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Getting started with 2D Arrays in C#
//Step 1: Declare a 2D array of type int syntax : dataType[,] arrayName = new dataType[rows, columns];
//Step 2: Initialize the 2D array with values
int[,] matrix = new int[3, 3] //3 rows and 3 columns
{
    {1, 2, 3}, //Row 0
    {4, 5, 6}, //Row 1
    {7, 8, 9}  //Row 2
};
for (int i = 0; i < 3; i++) //Iterate through rows
{
    for (int j = 0; j < 3; j++) //Iterate through columns
    {
        Console.Write(matrix[i, j] + " "); //Print each element followed by a space
    }
    Console.WriteLine(); //Move to the next line after each row
}
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };
Console.WriteLine("Jagged Array is :");
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
