// Заполняет спирально массив 4 на 4.
Console.Write("Inpun m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpun n: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] SpiralArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    int limDown = rows - 1;
    int limRight = columns - 1;
    int limTop = 0;
    int limLeft = 0;
    int x = 0;
    int y = 0;
    int dx = 0;
    int dy = 1;    
for (int i = 1; i <= rows * columns; i++)
    {
        arr[x, y] = i;
        if (dx == 1 && x == limDown)
        {
            dx = 0;
            dy = -1;
            limRight--;
        }
        if (dx == -1 && x == limTop)
        {
            dx = 0;
            dy = 1;
            limLeft++;
        }
        if (dy == 1 && y == limRight)
        {
            dx = 1;
            dy = 0;
            limTop++;
        }
        if (dy == -1 && y == limLeft)
        {
            dx = -1;
            dy = 0;
            limDown--;
        }
        x += dx;
        y += dy;
    }
    return arr;
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
printArray(SpiralArray(rows,columns));


