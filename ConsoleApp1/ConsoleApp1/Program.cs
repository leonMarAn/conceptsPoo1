
using ConsoleApp1;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2022, 2, 2));
    Console.WriteLine(new Date(2021, 4, 22));
    Console.WriteLine(new Date(2022, 15, 12));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}

//Date date1 = new Date(2022, 2, 2);

