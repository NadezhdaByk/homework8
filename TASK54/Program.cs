// Задает двумерный массив и упорядочивает по убыванию элементы 
//каждой строки двумерного массива.
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
            result[i, j] = new Random().Next(0,99);
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
int [,] SortArray(int[,] ResArray)
{
    for (int i=0; i<ResArray.GetLength(0); i++)
    {
        for(int k=1; k<=ResArray.GetLength(1); k++)
        {
           int m =0;
           for (int j = 0; j<(ResArray.GetLength(1)-1); j++)
           {
            if (ResArray[i,j]>ResArray[i,j+1])
            {
                m = ResArray[i,j];
                ResArray[i,j]=ResArray[i,j+1];
                ResArray[i,j+1]=m;
            }
           }
        }
    }
    return ResArray;
}
int [,] array = gatArray(m,n);
printArray(array);
Console.WriteLine();
printArray(SortArray(array));