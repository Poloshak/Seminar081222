// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// <aside>
// ❗️ Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// </aside>

Console.Clear();
Console.WriteLine("Введите значение первой стороны треугольника ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение второй стороны треугольника ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение третьей стороны треугольника ");
int c = int.Parse(Console.ReadLine());

bool Triangle (int storona1, int storona2, int storona3)
{
    return ((storona1+storona2)>storona3) && ((storona1+storona3)>storona2) && ((storona2+storona3)>storona1);
}

if (Triangle(a,b,c))
{
    Console.WriteLine("треугольник существует");
}
else Console.WriteLine("треугольник не существует");

//решение препода 
//Console.Clear();
// Console.Write("Введите стороны треугольника через пробел: ");

// string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

// if (IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }



// bool IsTriangle(int a, int b, int c)
// {
//     return ((a + b) > c && (a + c) > b && (b + c) > a);
// }