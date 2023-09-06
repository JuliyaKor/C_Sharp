/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void getNum3(int number)

{
    if (number < 100)
    {
        System.Console.WriteLine("Третей цифры нет!");
    }
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine($"Третяя цифра {number % 10}.");
    }
}
getNum3(num);

