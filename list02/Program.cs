/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.WriteLine("введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1<num2)
{
    Console.WriteLine($"число {num2} больше чем{num1}");
}
else if (num2<num1)
{
    Console.WriteLine($"число {num1} больше чем{num2}");
}
else
{
    Console.WriteLine("Числа равны");
}