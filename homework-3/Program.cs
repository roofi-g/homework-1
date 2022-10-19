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
