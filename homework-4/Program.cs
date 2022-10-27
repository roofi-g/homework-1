// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int getDegreeOfNumber(int numberA, int numberB)
{
    int current = 1;

    for (int i = 0; i < numberB; i++)
    {
        current = current * numberA;
    }
    return current;
}

int numberA = GetNumber("Введите число А: ");
int numberB = GetNumber("Введите число B: ");

int result = getDegreeOfNumber(numberA, numberB);

Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int getSumOfDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        int lastDigit = number % 10;
        sum = sum + lastDigit;

        number = number / 10;
    }
    return sum;
}

int numb = GetNumber("Введите положительное число: ");
int result = getSumOfDigits(numb);

Console.WriteLine($"Сумма цифр в числе {numb} равен {result}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// ввод элеменетов через консоль (через запятую. использовать метод string.Split())

Console.WriteLine("Введите 8 элементов через запятую: ");

string[] array = Console.ReadLine().Split(new char[] {','});

Console.WriteLine(string.Join(",", array));
