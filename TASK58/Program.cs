// Находит произведение двух заданных матриц
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
int [,] CompArray(int[,] ResArray1, int[,] ResArray2)
{
    int [,] ResArray = new int [ResArray1.GetLength(0), ResArray1.GetLength(1)];
    
    for (int i=0; i<ResArray1.GetLength(0); i++)
    {
        for (int j = 0; j<ResArray1.GetLength(1); j++)
        {
            ResArray[i,j]=ResArray1[i,j]*ResArray2[i,j];
        }
    
    }
    return ResArray;
}
int [,] array1 = gatArray(m,n);
int [,] array2 = gatArray(m,n);
printArray(array1);
Console.WriteLine();
printArray(array2);
Console.WriteLine();
printArray(CompArray(array1,array2));