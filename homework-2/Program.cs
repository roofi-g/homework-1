// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = 918;

// int getTheSecondDigit(int number) 
// {
//     int firstTwoDigits = number / 10;
//     int secondDigit = firstTwoDigits % 10;
//     return secondDigit;
// }

// Console.WriteLine(getTheSecondDigit(number));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = 32679;

// int getTheThirdDigit(int number) 
// {
//     while (number >= 1000) number /= 10;
//     int theThirdNumber = number % 10;
//     return theThirdNumber;
// }

// if (number >= 0 && number < 100) {
//     Console.WriteLine("третьей цифры нет");
// } else {
//     Console.WriteLine(getTheThirdDigit(number));
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int number = 6;

void Programm(int num)
{
    if(num == 6 || num == 7){
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }
}

Programm(number);
