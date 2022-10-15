/* **Задача 2:** Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.WriteLine("Please, enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter second number");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine("Max=" + a);
}
else 
{
    Console.WriteLine("Max=" + b);
}
*/
/***Задача 4:** Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
/*
Console.WriteLine("Please, enter first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter second number:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter third number:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a < b) max = b;
if (c > b) max = c;
Console.WriteLine("Max=" + max);*/

/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
// int Result = Num % 10;
/*
Console.WriteLine("Please, enter number:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N) 
{
    Console.Write(i + " ");
    i+=2;
}*/
