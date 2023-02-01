Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи число:");
int b = Convert.ToInt32(Console.ReadLine());
int p;
if (a < b)
{

    p = a;
    a =(a + b) / 2;
    b = p * b * 2;

}
else if (a == b)
{

}
else
{
    p = b;
    b =(a + b) / 2;
    a = p * a * 2;
}

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

