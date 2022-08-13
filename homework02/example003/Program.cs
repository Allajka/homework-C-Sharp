﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int checkNumber(int numbers)
{
    int amountNumber = 0;
    while (numbers > 0)
    {
        numbers /= 10;
        amountNumber++;
    }
    return amountNumber;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber=checkNumber(number);
int control = sumNumber - 3;
int i = 0;

if (sumNumber >= 3)
{
    while (i < control)
    {
        number = number / 10;
        i++;
    }
    int thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра числа {thirdNumber}");
}

if (sumNumber < 3)
{
    Console.WriteLine($"Нет третьей цифры в числе {number}");
}

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string lineNumber = Convert.ToString(number);

// if (lineNumber.Length > 2)
// {
//     Console.WriteLine($"Третья цифра числа {lineNumber[2]}");
// }
// else
// {
//     Console.WriteLine("Нет третей цифры");
// }

// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// char[] arr = number.ToCharArray();;

// if (arr.Length >= 3) Console.WriteLine($"Третья цифра числа {arr[2]}");
// else Console.WriteLine("Нет третей цифры");