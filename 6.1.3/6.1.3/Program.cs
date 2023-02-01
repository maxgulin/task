using System;

Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int b = Convert.ToInt32(Console.ReadLine());
int p = a % b;
if (p==0)
{
    Console.WriteLine(a + "является делителем");
}
else
{
    Console.WriteLine(a + "не является делителем");
}
