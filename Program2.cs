﻿
//Задача 10
int a, b;

Console.Write("Задача 10: \n");
Console.Write("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. \n");
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a / 100 != 0 && a / 100 < 9)
{ Console.Write($"Вторая цифра этого числа = {(a % 100) / 10}\n"); }
else
{ Console.Write("Введено не трёхзначное число\n"); }
Console.Write("=============================\n");

//==========================================================================================================
//==========================================================================================================

//Задача 13
Console.Write("Задача 13: \n");
Console.Write("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.\n");
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);


if (a / 100 != 0)
{
    while (a >= 1000)
    { a /= 10; }
    b = a % 10;
    Console.Write($"третья цифра этого числа = {b}\n");
}
else
{ Console.Write("третьей цифры нет\n"); }
Console.Write("=============================\n");

//==========================================================================================================
//==========================================================================================================
//Задача 15
Console.Write("Задача 15: \n");
Console.Write("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. \n");
Console.Write("Введите число (день недели) от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out a);

if (a < 1 || a > 7)
{ Console.Write("Введенное значение не от 1 до 7! \n"); }
else if (a >= 1 && a <= 5)
{ Console.Write("Является ли выходным: Нет \n"); }
else if (a >= 6 && a <= 7)
{ Console.Write("Является ли выходным: Да \n"); }

Console.Write("=============================\n");

//==========================================================================================================
//==========================================================================================================
