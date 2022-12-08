// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[]FillPrintArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,101);
    }
    Console.Write($"[{string.Join(", ",arr)}]");
    return arr;
}

int FindNumsInDiapazon (int[] arr, int min, int max)
{
    int sum = 0;
    foreach(int i in arr)
    {
        if(i >= min && i <= max) 
        sum ++;
    }
    Console.WriteLine($"{sum}");
    return sum;
}

Console.Clear();
int [] array = new int [10];
FillPrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите минимум ");
int minimum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимум ");
int maximum = int.Parse(Console.ReadLine());

FindNumsInDiapazon(array, minimum, maximum);

