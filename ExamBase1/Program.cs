// See https://aka.ms/new-console-template for more information
using ExamBase1.Day1;

Console.WriteLine("**************************************************************************\n\r");

Console.WriteLine("**************************************************************************\n\r");

//data 1
RequestEmployeeData data = new RequestEmployeeData()
{
    Name = "Vicky Chhetri",
    Address = "Jalandhar",
    Mobile = 9780533745,
    Age = 23,
    VNumber = "v813271"
};

//data 2
RequestEmployeeData data2 = new RequestEmployeeData()
{
    Name = "Vicky Chhetri",
    Address = "Jalandhar",
    Mobile = 9780533745,
    Age = 27,
    PNumber = "p1000001"
};



IEmployee vemployee = new VisitingEmployee(data);
IEmployee pemployee = new PermanentEmployee(data2);




Console.WriteLine(vemployee.GetCardNumber());
Console.WriteLine(pemployee.GetCardNumber());
Console.WriteLine("\n\r**************************************************************************\n\r");
Console.WriteLine("**************************************************************************\n\r");