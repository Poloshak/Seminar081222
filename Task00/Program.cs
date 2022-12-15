// Вывести все числа от N до 1

// void a(int b){
//     if (b >= 1){
//         a(b - 1);
//         Console.Write($"{b} ");
//     }
// }
// a(7);

// using System;
// using static System.Console;

// Clear();
// Write("Введите N: ");
// int n=int.Parse(ReadLine());

// WriteLine(PrintNumbers(n));

// string PrintNumbers(int end)
// {
//     if (end == 1) 
//     {
//         return "1";
//     }
//     return (PrintNumbers(end - 1) + ' ' + end.ToString());
// }

using System;
using static System.Console;


Clear();
Write("Введите M: ");
int m=int.Parse(ReadLine());
Write("Введите N: ");
int n=int.Parse(ReadLine());

WriteLine(PrintNumbers(m,n));

string PrintNumbers(int start, int end)
{
    if (start == end) 
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}