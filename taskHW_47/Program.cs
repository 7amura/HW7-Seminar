// Задача 47: 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 1 -3,3 8 -9,9 8 7,8 -7,1 9

// Math.Round(new Random().NextDouble(), 1) - Объединение двух методов, кот создадут числа от 0 до 1 с плавающей запятой и + метод new Random().Next(-9,10)
// с диапозоном случайных чисел. Прибавив любое число из данного диапозона к какому-то числу, то получим какое-то число с запятой.
// Console.Write(&"{matrix[rows, column]} "); - вывод по строчно.

Console.WriteLine("Введите размер массива M: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер массива N: ");
int b = int.Parse(Console.ReadLine()!);

void CreateArray(int m, int n)
{
    double[,] matrix = new double [m, n];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for(int column = 0; column < matrix.GetLength(1); column++)
    {
        matrix[rows, column] = new Random().Next(-9,10) + Math.Round(new Random().NextDouble(), 1);
        Console.Write($"{matrix[rows, column]} ");
    }
    Console.WriteLine(" ");
}
Console.WriteLine();
}

CreateArray(a,b);
// Console.WriteLine();