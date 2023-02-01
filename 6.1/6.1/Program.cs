Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи число:");
int b = Convert.ToInt32(Console.ReadLine());
int p;
if (a < b)
{

    p = a;
    a = a + b;
    b = p * b;

}
else if (a == b)
{

}
else
{
    p = b;
    b = a + b;
    a = p * a;

}

Console.WriteLine("a = "+a);
Console.WriteLine("b = "+b);

     