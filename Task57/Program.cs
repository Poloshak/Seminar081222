// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[] ConvertToOneLine (int[,]arr)
{
    int[]arrOne=new int[arr.GetLength(0)*arr.GetLength(1)];
    int k=0;
    for(int i = 0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
        arrOne[k]=arr[i,j];
        k++;
        }
        
    }

    return arrOne;
}

void OrganizeArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if(arr[i]>arr[j])
            {
                int k=arr[i];
                arr[i]=arr[j];
                arr[j]=k;
            }
        }
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintData(int[] arr)
{
    int element = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] != element)
        {
            Console.WriteLine($"{element} встречается {count} раз");
            element = arr[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{element} встречается {count} раз");
}


Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());
int[,]array = GetArray(rows,columns, 5, 15);
PrintArray(array);
int[]arrayOne = new int[rows*columns];
arrayOne=ConvertToOneLine(array);
Console.WriteLine($"[{string.Join(", ",arrayOne)}]");
OrganizeArray(arrayOne);
Console.WriteLine($"[{string.Join(", ",arrayOne)}]");
PrintData(arrayOne);



