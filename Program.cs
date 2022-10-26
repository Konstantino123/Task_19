// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
{
    if (number[0] == number[4])
    {
        Console.Write("{number} - Палидром");
    }
    else
    {
        Console.Write("{number} - НЕ Палидром");
    }
}