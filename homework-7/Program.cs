// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double[,] InitMatrix(int m, int n)
{
    double [,] resultMatrix = new double[m,n];
    Random rnd = new Random();

    int min = -10;
    int max = 10;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i,j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }

    return resultMatrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
double[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     int result = int.Parse(Console.ReadLine());
//     return result;
// }

// int[,] InitMatrix(int m, int n)
// {
//     int [,] resultMatrix = new int[m,n];
//     Random rnd = new Random();

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             resultMatrix[i,j] = rnd.Next(0,10);
//         }
//     }
//     return resultMatrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int GetElement(int[,] matrix, int coordinates)
// {
//     int x = (coordinates % 100) / 10;
//     Console.WriteLine($"x : {x}");
//     int y = coordinates % 10;
//     Console.WriteLine($"y : {y}");
//     return matrix[x-1, y-1];
// }

// int m = GetNumber("Введите число m:");
// int n = GetNumber("Введите число n:");
// int[,] matrix = InitMatrix(m,n);
// PrintMatrix(matrix);

// try
// {
//     Console.WriteLine(GetElement(matrix, GetNumber("Введите двузначное число с координатами в матрице: ")));
// }
// catch 
// {
//     Console.WriteLine("такого числа в массиве нет");
// };


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[,] InitMatrix(int m, int n)
{
    int [,] resultMatrix = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i,j] = rnd.Next(0,10);
        }
    }

    return resultMatrix;
}

void PrintArithmeticMean(int[,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        double sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            int current = matrix[i, j];
            sum += current;
        }
        Console.Write($"{Math.Round(sum / matrix.GetLength(0), 2)}; ");
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);

PrintArithmeticMean(matrix); */