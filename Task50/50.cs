/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int rowNumber= GetNumberFromUser("Введите номер строки: ", "Ошибка ввода!");
int columnNumber = GetNumberFromUser("Введите номер столбца: ", "Ошибка ввода!");
CheckNumberInArray(array, rowNumber, columnNumber);

 



///////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


//////////////////////

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine(); 
    }
}

//////////////////////


int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) 
           return userNumber;
        Console.WriteLine(errorMessage);   
    }
}

////////////////////

void CheckNumberInArray(int [,] array, int row, int column)
{
    int number=0;
    if(row<array.GetLength(0)   && column<array.GetLength(1) )
    {
        if (row>-1 && column>-1) 
        {
            number = array[row-1,column-1];
            Console.WriteLine($"{row}, {column} -> {number}"); 
        }
    }
    if (row > array.GetLength(0) - 1 || column > array.GetLength(1) - 1 || row<0 || column<0)
    {
       Console.WriteLine("Ошибка ввода!");
       
    }    
}
   