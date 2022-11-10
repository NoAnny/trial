// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirdDigit(int number)
    {
        while (number > 999)
         {
            number = number / 10;
         }
         return number % 10;
    }

Console.WriteLine("Введите число");
int usernumber = int.Parse(Console.ReadLine ()!);
if (usernumber < 100) Console.WriteLine("У числа нет третьей цифры");
else Console.WriteLine(ThirdDigit(usernumber));
