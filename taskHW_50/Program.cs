// Задача 50: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив: 
// 14 72
// 59 23
// 84 24
// 17 -> такого числа в массиве нет


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

void SearchEl(int[,] array, int position)
{
    if(position%10 > array.GetLength(1) || position/10 > array.GetLength(0))
    Console.WriteLine($" Числа с позицией ({position/10}*{position%10}) в массиве нет.");
    else
    {
        Console.WriteLine($" Число с позицией ({position/10}*{position%10}) = {array[position/10 - 1, position%10 - 1]} ");
    }
}

Console.WriteLine("Введите размер массива M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите размер массива N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите поицию элемента X*Y(без пробела): ");
int i = int.Parse(Console.ReadLine()!);

SearchEl(CreateArray(m,n),i!);
Console.WriteLine();