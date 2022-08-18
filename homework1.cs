//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("input first number ");
int Num1=Convert.ToInt32(Console.ReadLine());
Console.Write("input second number ");
int Num2=Convert.ToInt32(Console.ReadLine());
if (Num1<Num2)
{
    Console.WriteLine($"Max = {Num2} Min = {Num1} ");
}
else
{
    Console.WriteLine($"Max = {Num1} Min = {Num2} ");
}
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("input first number ");
int Max=Convert.ToInt32(Console.ReadLine());
int temp;
Console.Write("input second number ");
temp=Convert.ToInt32(Console.ReadLine());
if (Max<temp)
{
    Max=temp;
}
Console.Write("input third number ");
temp=Convert.ToInt32(Console.ReadLine());
if (Max<temp)
{
    Max=temp;
}
    Console.WriteLine($"Max = {Max}");
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("input  number ");
int Number=Convert.ToInt32(Console.ReadLine());
if ((Number%2)==0)
{
    Console.WriteLine($"{Number} is Even number");
}
else
{
    Console.WriteLine($"{Number} is Odd number");
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("input  number ");
int Number=Convert.ToInt32(Console.ReadLine());
int count=2;
while (count<(Number-(Number%2)))
{
    Console.Write($"{count}, ");
    count=count+2;
}
Console.Write($"{(Number-(Number%2))}");
*/