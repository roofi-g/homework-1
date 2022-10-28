// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*  инициализация массива случайными положительными трёхзначными числами.
int[] InitArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(99,1000);
    }

    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

//получение количество четных чисел в массиве
int GetEvenNumbers(int[] array)
{
    int numberOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            numberOfEvenNumbers += 1;
        }
    }
    return numberOfEvenNumbers;
}

int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);

Console.WriteLine($"Количество четных чисел в массиве: {GetEvenNumbers(arr)}"); */



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/* инициализация массива случайными числами.
int[] InitArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-100,100);
    }

    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

//получение суммы элементов на нечетных позициях массива
int GetSum(int[] array)
{
    int current = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            current += array[i];
        }
    }
    return current;
}

int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях : {GetSum(arr)}"); */



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// инициализация массива случайными числами.
int[] InitArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-10,100);
    }

    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// получаем максимальное и минимальное значения в массиве
(int, int) GetMaxAndMinValue(int[]array)
{
    int maxCurrentValue = array[0];
    int minCurrentValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(maxCurrentValue < array[i])
            maxCurrentValue = array[i];
        else if(minCurrentValue > array[i])
            minCurrentValue = array[i];
    }
    return (maxCurrentValue, minCurrentValue);
}

int GetDifference(int maxValue, int minValue)
{
    return maxValue - minValue;
}

int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);

(int maxValue, int minValue) = GetMaxAndMinValue(arr);
int difference = GetDifference(maxValue,minValue);

Console.WriteLine($"Максимальное значение: {maxValue}, минимальное значение {minValue}. Разница между максимальным и минимальным значением: {difference}");