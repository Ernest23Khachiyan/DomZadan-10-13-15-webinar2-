﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random random = new Random();
int randomNamber = random.Next(100, 1000);

Console.WriteLine(randomNamber);

int secondNumber = (randomNamber / 10) % 10;


Console.WriteLine(secondNumber);

//=========================================================================================================================================================================================


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int array = num;
string text = array.ToString();
if (num < 0)
{
    Console.WriteLine("Число не трехзначное, но третий символ: ");
}
if (text.Length < 3)
{
    Console.WriteLine("Третьей цифры НЕТ в данном числе");
}

Console.WriteLine(text[2]);

//==========================================================================================================================================================================


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 и нажмите Enter");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 5)
{
    Console.WriteLine("Не выходной день недели");
}

else
{
    Console.WriteLine("Выходной день недели");
}
{
if (day > 7)
    Console.WriteLine("На какой нибудь другой планете");
}

Console.ReadLine();