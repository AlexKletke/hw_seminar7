//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using static System.Console;
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,]inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"\t{inArray[i,j]}");
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
Write("a two-dimensional array filled with integer numbers: ");
WriteLine();
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

for(int j = 0; j < array.GetLength(1); j++)
{
    double ArithmeticMeanColumn = 0;
    double SumElementsColumn = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        SumElementsColumn+= array[i,j];
    }
    ArithmeticMeanColumn = SumElementsColumn / array.GetLength(0);
    WriteLine($"the arithmetic mean of the elements in column with number {j+1} = {ArithmeticMeanColumn:F2}");
    WriteLine();
}


