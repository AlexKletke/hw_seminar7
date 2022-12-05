// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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




