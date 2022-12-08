// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
int[] array = new int[4];
FillPrintArray(array);

Console.WriteLine();
for (int i = 0; i<array.Length; i++)
{
    array[i] = array [i]* -1;
}
Console.Write($"[{string.Join(", ",array)}]");
