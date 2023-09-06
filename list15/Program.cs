/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру: ");
int userNum = Convert.ToInt32(Console.ReadLine());
if (userNum < 6)
{
    Console.WriteLine("Этот день не является выходным");
}
else if(userNum==6 || userNum==7)
{
    Console.WriteLine("Этот день является выходным");
}
else 
{
    Console.WriteLine($"введите число от 1 - 7");
    
}
