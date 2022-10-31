// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел: ");

int[] array = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше нуля: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
float GetNumberFromUser(string message)
{
    Console.WriteLine(message);
    float result = float.Parse(Console.ReadLine());
    return result;
}

double GetYPoint(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double GetXPoint(double b1, double k1, double b2, double k2)
{
    double x1 = k1 + k2 * (-1);
    double x2 = b1 + b2 * (-1);

    double x = x2 / (x1 * (-1));

    return x;
}

double valueB1 = GetNumberFromUser("Введите значение b1: ");
double valueK1 = GetNumberFromUser("Введите значение k1: ");
double valueB2 = GetNumberFromUser("Введите значение b2: ");
double valuek2 = GetNumberFromUser("Введите значение k2: ");

double x = GetXPoint(valueB1, valueK1, valueB2, valuek2);
double y = GetYPoint(valueB1, valueK1, x);

Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})"); */
