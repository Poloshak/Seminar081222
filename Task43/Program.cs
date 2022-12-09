// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите b1, k1, b2 и k2 через пробел: ");
string[] K = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
KoordinatyTochkiPeresecheniya(K);


double KoordinatyTochkiPeresecheniya (string[] koord)
{
    Console.WriteLine($"{int.Parse(koord[0])}; {int.Parse(koord[1])}; {int.Parse(koord[2])}; {int.Parse(koord[3])}");
    double x = (int.Parse(koord[2]) - int.Parse(koord[0])) / (int.Parse(koord[1]) - int.Parse(koord[3]));
    Console.WriteLine($"{x}");
    double y = int.Parse(koord[1]) * x + int.Parse(koord[0]);
    Console.WriteLine($"Координаты точки пересечения ({x}; {y})");
    return x;
    return y;
    
}