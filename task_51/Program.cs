// Задача 51: 
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив: 
// 1 47 2
// 5 92 3
// 8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] CreateArray(int m, int n)
{
    int[,] matrix = new int[m ,n];
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[rows, column] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, column]} ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
    return matrix;
}


void SumLine(int[,] array)
{
    int sumEl = 0;
    for(int column = 0; column < array.GetLength(1); column++)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            if(rows == column) sumEl += array[rows, column];
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали равна: {sumEl} ");
}
SumLine(CreateArray(3,4));