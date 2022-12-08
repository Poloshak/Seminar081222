// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[]FillPrintArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,101);
    }
    Console.Write($"[{string.Join(", ",arr)}]");
    return arr;
}

Console.Clear();
int [] array = new int [5];
FillPrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число от -100 до 100 ");
int num = int.Parse(Console.ReadLine());
if(FindNumber(array, num)) Console.WriteLine("Да");
else Console.WriteLine("Нет");


bool FindNumber (int[] arr, int number)
{
    foreach(int i in arr)
    {
        if(i == number) 
        return true;
    }
    return false;
}


