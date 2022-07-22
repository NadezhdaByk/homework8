// Формирует трёхмерный массив из неповторяющихся двузначных чисел. 
// Построчно выводит массив, добавляя индексы каждого элемента.
// Console.WriteLine("Введите кол-во строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int n = Convert.ToInt32(Console.ReadLine());


// void printArray(int[,,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int z = 0; z < inArray.GetLength(2); z++)
//             {
//             Console.Write($"{inArray[i, j, z]} ({i},{j},{z}) ");
//             }
//         }
//         Console.WriteLine();
//     }
// }
//
int [] SelectArray(int N)
{
    int [] arr = new int [N];
    for (int i=1; i<N; i++)
    {
        arr[0]= new Random().Next(9,99);
        //arr[1]=new Random().Next(9,99);
        for(int j=i-1; j>=0; j--)
        {
            if (arr[i]==arr[j]) 
            {
                arr[i]= new Random().Next(9,99);
                j=i;
            }    
        }
    }
    return arr;
}

int [,,] ResultArray(int[]inArray, int xlocal, int ylocal, int zlocal)
{
    int [,,] array = new int [xlocal, ylocal, zlocal];
    int x = 0;
    for(int i=0; i<xlocal; i++)
    {
        for (int j=0; j<ylocal; j++)
        {
            for (int z=0; z<zlocal; z++)
            {
                array [i,j,z] = inArray [x];
                x++;
            }
        }
    }
    return array;
}
// void printArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($"{inArray[i]}  ");
//     }
// }

void printArray2(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
            Console.Write($"{inArray[i, j, z]} ({i},{j},{z}) ");
            }
        }
        Console.WriteLine();
    }
}
int [] array = SelectArray(8);
Console.WriteLine(string.Join(", ",array));
//printArray1(array);
printArray2(ResultArray(array,2,2,2));
