//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool DayWeekend(int day)
{
    return day > 5;
}

Console.WriteLine(" Сегодня выходной?");
Console.WriteLine("Чтобы узнать, введите номер дня недели (от 1 до 7)"); 
int num = int.Parse(Console.ReadLine()!); 
Console.WriteLine(DayWeekend(num));
