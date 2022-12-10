// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.




int[] MassiveCopy(int[] arr)
{
    int[] newarr = new int [arr.Length];
    int i = 0;
    int j = 0;
    while(i<arr.Length)
    {
        newarr[j] = arr[i];
        i++;
    } 
    Console.WriteLine($"Копия массива: {String.Join(" ", arr)}");
    return newarr;
}

int[] FillArray (int[] arr)
{
    int i=0;
    while(i<arr.Length)
    {   
        arr[i] = new Random().Next(10,100);
        i++;
    }
    Console.WriteLine(String.Join(" ", arr));
    return arr;
}

 Console.Clear();
 int[] array = new int [10];
 FillArray(array);
 MassiveCopy(array);

