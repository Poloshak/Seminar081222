// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8


using System;
using static System.Console;


Clear();
Write("Введите число A: ");
int m = int.Parse(ReadLine());
Write("Введите число B: ");
int n = int.Parse(ReadLine());

WriteLine($"число {m} в степени {n} = {NumDegree(m,n)}");

int NumDegree(int number, int degree)
{
    if (degree == 0)
        return 1;
    return (number* NumDegree(number,degree-1));
}