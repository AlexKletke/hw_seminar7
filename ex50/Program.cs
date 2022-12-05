//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using static System.Console;
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        }
    }
    return result;
}
void PrintArray(double[,]inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"\t{inArray[i,j]:F2}");
        }
        WriteLine();
    }
}
Clear();
Write("enter quantity of rows: ");
int rows = int.Parse(ReadLine());
Write("enter quantity of columns: ");
int columns = int.Parse(ReadLine());
Write("enter min number of array: ");
int minValue = Convert.ToInt32(ReadLine()!);
Write("enter max number of array: ");
int maxValue =  Convert.ToInt32(ReadLine()!);
Write("a two-dimensional array filled with random real numbers: ");
WriteLine();
double[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

Write("enter number of row: ");
int numrow = int.Parse(ReadLine());
Write("enter number of column: ");
int numcolumn = int.Parse(ReadLine());
if (numrow > array.GetLength(0) || numcolumn > array.GetLength(1))
    WriteLine("there is no such element in array");
else    
    WriteLine($"element value = {array[numrow-1, numcolumn-1]:F2}");

