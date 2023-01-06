// Задача 49: 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2
// 5 92 3
// 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 58129
// 8 42 4
// 20 мин
  
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
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for(int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if(rows%2 == 0 && column%2 == 0) newArray[rows, column] = (int)Math.Pow(array[rows, column ], 2);
            else newArray[rows, column] = array[rows, column];
            Console.Write($"{newArray[rows, column]} ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

CreateNewArray(CreateArray(4, 4));