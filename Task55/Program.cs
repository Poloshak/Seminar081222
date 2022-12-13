// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void ReplacedArray(int[,] arr)
{
    int rowCount = arr.GetLength(0) - 1;
    int columnsCount = arr.GetLength(1) - 1;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            int k = arr[j, i];
            arr[j, i] = arr[i, j];
            arr[i, j] = k;
        }
    }
}

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());
int[,]array = GetArray(rows,columns, 5, 15);
if (array.GetLength(0) != array.GetLength(1)) 
    {
        Console.WriteLine("Невозможно поменять");
        return;
    }
PrintArray(Array);
Console.WriteLine();
ReplacedArray(Array);
PrintArray(Array);