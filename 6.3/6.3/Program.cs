Console.WriteLine("введите букву трансп средства");
string n = Convert.ToString(Console.ReadLine());
switch (n)
{
    case "а":
        Console.WriteLine(" автомобиль = 100км/ч");
        break;
    case "в":
        Console.WriteLine(" велосипед = 12км/ч");
        break;
    case "м":
        Console.WriteLine("мотоцикл = 80км/ч");
        break;
    case "с":
        Console.WriteLine("самолет = 800км/ч");
        break;
    case "п":
        Console.WriteLine("поезд = 400км/ч");
        break;
}