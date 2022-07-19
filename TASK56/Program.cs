// В заданном массиве находит строку с наименьшей суммой элементов.
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] gatArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0,9);
        }
    }
    return result;
}
void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}
string MaxString(int[,] ResArray)
{
    int ressum=999;
    int count=0;
    for (int i=0; i<ResArray.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j<ResArray.GetLength(1); j++)
        {
            sum+=ResArray[i,j];
        }
        if (sum<ressum) {ressum=sum; count = i;}
    }
    return $"наименьшая сумма элементов в {count} строке  и равна {ressum}";
}
int [,] array = gatArray(m,n);
printArray(array);
Console.WriteLine(MaxString(array));
