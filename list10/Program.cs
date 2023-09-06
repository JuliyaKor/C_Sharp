/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int getMiddleDigit(int num)
{
    return num / 10 % 10;
}

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num > 99 && num < 1000)
{
    Console.WriteLine($"Цифра посередине: {getMiddleDigit(num)}");
}
else
{
    Console.WriteLine("Число не является трёхзначным");
}
