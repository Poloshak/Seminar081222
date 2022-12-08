// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();
Console.Write("Введите элементы через пробел ");
string elements = Console.ReadLine();
int[] arr = String_con_Int_mas(elements);
Console.Write($"Результат {String.Join(" ", Um_array(arr))}");


int[] String_con_Int_mas(string s)
{
    string[] nums = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for(int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}


int[] Um_array(int[] array)
{
    int[] result = new int [(array.Length+1)/2];
    for(int i = 0; i<array.Length/2; i++)
    {
        result[i] = array[i]*array[array.Length -1 -i];
    }
    if (array.Length %2 == 1)
    {
        result[result.Length-1] = array[array.Length/2];
    }
    return result;
}