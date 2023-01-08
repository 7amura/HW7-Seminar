// Задача 52: 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: 14 72
// 59 23
// 84 24
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



  int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a,b];
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

void Avarage(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int column = 0; column < array.GetLength(1); column++)
    {
        double sumEl = 0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sumEl += array[rows, column];
        }
        double avarageEl = Math.Round(sumEl/array.GetLength(0), 1);
        Console.Write($"{avarageEl}"); 
    }
     
     Console.WriteLine("");
}

Console.WriteLine("Введите размер массива M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите размер массива N: ");
int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine();
Avarage(CreateArray(m,n)!);
Console.WriteLine();