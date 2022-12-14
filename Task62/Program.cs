// Задача 62: Заполните спирально массив 4 на 4


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,]array = new int[4,4];
int sum = 1;
for (int j=0;j<4;j++)
{
    array[0,j]=sum;
    sum++;
}
sum=5;
for (int i=1;i<4;i++)
{
    array[i,3]=sum;
    sum++;
}
sum=8;
for (int j=2; j>=0; j--)
{
    array[3,j]=sum;
    sum++;
}
sum=11;
for(int i=2; i>=1; i--)
{
    array[i,0]=sum;
    sum++;
}
sum=13;
for(int j=1;j<=2;j++)
{
    array[1,j]=sum;
    sum++;
}
sum=15;
for(int j=2;j>=1;j--)
{
    array[2,j]=sum;
    sum++;
}

PrintArray(array);