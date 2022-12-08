// 
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



int[]FillPrintArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    Console.Write($"[{string.Join(", ",arr)}]");
    return arr;
}

int[]array = new int[12];
FillPrintArray(array);
int SumOtr = 0;
int SumPol = 0;
for (int i =0; i<array.Length; i++)
{
    if(array[i] >0)
    {
        SumPol = SumPol + array[i];
    }
    else SumOtr = SumOtr + array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов -> {SumPol}");
Console.WriteLine($"Сумма отрицательных элементов -> {SumOtr}");
