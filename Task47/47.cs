/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Clear();

Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine() ??"");
Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine() ??"");

double[,] array = GetArray(rows, columns, -99, 100);

PrintArray(array);

/////////////////////////
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for (int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            var random= new Random();
            double dRandom= random.NextDouble();
            result[i,j] = Math.Round((dRandom*(maxValue-minValue)+minValue), 2);
        }
    }
    return result;
}

///////////////////
void PrintArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(String.Join(" ", array[i,j]));
        }
        Console.WriteLine();
    }
}