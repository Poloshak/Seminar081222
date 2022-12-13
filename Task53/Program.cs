// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


void ChangeRowArray(int[,] arr)
{
    int rowCount = arr.GetLength(0) - 1;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int k = arr[0, i];
        arr[0, i] = arr[rowCount, i];
        arr[rowCount, i] = k;
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
int[,]Array = GetArray(rows,columns, 5, 15);
PrintArray(Array);
Console.WriteLine();
ChangeRowArray(Array);
PrintArray(Array);