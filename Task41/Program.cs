// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int NumsOverZero (string[] arr)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if (int.Parse(arr[i])>0) count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string[] M = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Введено {NumsOverZero(M)} чисел больше 0");