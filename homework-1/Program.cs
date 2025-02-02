﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Number1 = 5;
int Number2 = 7;

if (Number1 > Number2) {
    Console.Write($"Большее число: {Number1}, меньшее число : {Number2}");
} else {
    Console.Write($"Большее число: {Number2}, меньшее число : {Number1}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int number1 = 22;
int number2 = 3;
int number3 = 9;

int max = 0;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write($"Максимальное число: {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int number = 7;

int result = number % 2;

if (result == 0) {
    Console.Write($"Да, число является четным");
} else {
    Console.Write($"Нет, число не является четным");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int number = new Random().Next(1, 10);
Console.WriteLine(number);

for (int i = 1; i <= number; i++) {
    if (i % 2 == 0) {
        Console.Write(i);
    }
}