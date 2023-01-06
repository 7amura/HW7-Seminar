// Задача 48: 
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4. 
// 0 1 23
// 1 2 34
// 2 3 45

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


void CreateNewArray(int[,] array)
{
    for(int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[rows, column] = rows + column;
            Console.Write($"{array[rows, column]} ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

CreateNewArray(CreateArray(3, 4));
