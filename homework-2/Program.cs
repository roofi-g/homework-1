// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = 918;

int getTheSecondDigit(int number) 
{
    int firstTwoDigits = number / 10;
    int secondDigit = firstTwoDigits % 10;
    return secondDigit;
}

Console.WriteLine(getTheSecondDigit(number));