// See https://aka.ms/new-console-template for more information
using Console_GitTest.LogHelper;

Console.WriteLine("Hello, World!");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i}. Erol\n");
}

List<int> listInt = new()
{
   1,
   2,
   3
};
foreach (var item in listInt)
{
    Console.WriteLine($"{item}.ci satır");
}

Logger Logger = new();

Console.WriteLine(Logger);