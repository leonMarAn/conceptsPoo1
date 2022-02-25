
using ConsoleApp1;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmploye()
{
    Id = 1010,
    FirstName = "Sandra ",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
    //This constructor can grow more, therefore there is no need to close with (;)
};
Console.WriteLine(employee1);
Employee employee2 = new CommissionEmployee()
{
    Id = 2010,
    FirstName = "Jose ",
    LastName = "Martin",
    BirthDate = new Date(1998, 12, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    Sales = 32000000M,
    CommisionPercentaje = 0.03F 
};
Console.WriteLine(employee2);
//try
//{
//    Console.WriteLine(new Date(2022, 2, 2));
//    Console.WriteLine(new Date(2021, 4, 22));
//    Console.WriteLine(new Date(2022, 15, 12));
//}
//catch (Exception error)
//{

//    Console.WriteLine(error.Message);
//}

//Date date1 = new Date(2022, 2, 2);

