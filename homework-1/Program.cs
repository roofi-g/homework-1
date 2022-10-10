// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// int Number1 = 5;
// int Number2 = 7;

// if (Number1 > Number2) {
//     Console.Write($"Большее число: {Number1}, меньшее число : {Number2}");
// } else {
//     Console.Write($"Большее число: {Number2}, меньшее число : {Number1}");
// }

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