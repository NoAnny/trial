//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Please, enter any number");
int number = int.Parse(Console.ReadLine()!);
if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Everything is OK");
else Console.WriteLine("DAMAGE");

