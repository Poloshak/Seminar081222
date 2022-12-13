// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

Console.Write("Введите количество строк массива1: ");
int rows1=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива1: ");
int columns1=int.Parse(Console.ReadLine());
Console.Write("Введите количество строк массива2: ");
int rows2=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива2: ");
int columns2=int.Parse(Console.ReadLine());
int[,]array1 = GetArray(rows1,columns1, 5, 15);
PrintArray(array1);
Console.WriteLine();
int[,]array2 = GetArray(rows2,columns2, -5, 5);
PrintArray(array2);
if(columns1!=rows2) Console.WriteLine("Матрицы умножить нельзя");
int[,]arrayProizvedenie = new int [rows1,columns2];
for(int i = 0; i<arrayProizvedenie.GetLength(0); i++)
{
    for(int j = 0; j<arrayProizvedenie.GetLength(1); j++)
    {
        arrayProizvedenie[i,j]=
    }
}