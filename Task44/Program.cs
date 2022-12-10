// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// <aside>
// ❗️ Числа Фибоначчи — числовая ****последовательность, каждый элемент которой равен сумме двух предыдущих.

// </aside>


int [] Fib(int n)
{
    int a = 0;
    int b = 1;
    int c = 0;
    int [] fi = new int[n];
    fi[0] = 0;
    for(int i = 1; i<n; i++)
    {
        
        c= a+b; //нужно определить вне цикла
        a=b;
        b=c;
        fi[i] = a;
        Console.WriteLine(a+" ");
    }
    return fi;
}

Console.Clear();

int n = 7;

int[] fibanacci = Fib(n);
Console.WriteLine(String.Join(" ",fibanacci));