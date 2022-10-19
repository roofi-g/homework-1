// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = 23432;

void HeckingForPalindrome(int num)
{
    int current = num;
    int newValue = 0;
    while(num > 0) 
    {
        int theLastDigit = num % 10;
        newValue = newValue * 10 + theLastDigit;
        num = num / 10;
    }
    if(current == newValue)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}

HeckingForPalindrome(number);

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void GetDistanseBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY, int firstZ, int secondZ) 
{
    double result = 0;

    double tempX = Math.Pow(secondX - firstX, 2);
    double tempY = Math.Pow(secondY - firstY, 2);
    double tempZ = Math.Pow(secondZ - firstZ, 2);

    result = Math.Sqrt(tempX + tempY + tempZ);

    Console.WriteLine($"Расстояние между двумя точками {Math.Round(result,2)}");
}

GetDistanseBetweenTwoPoints(7, 1, -5, -1, 0, 9);
