// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int SecondDigit(int number)
{
    return (number % 100) / 10;
}
Console.WriteLine("Введите трехзначное число");
int usernumber = int.Parse(Console.ReadLine ()!);
Console.WriteLine(SecondDigit(usernumber));
