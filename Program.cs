// See https://aka.ms/new-console-template for more information
string greeting = @"Welcome to Thrown for a Loop
Your one-stop shop for used sporting equipment!";
Console.WriteLine(greeting);
Console.WriteLine("Please choose an option:");
string response = Console.ReadLine();

if (string.IsNullOrEmpty(response))
{
    Console.WriteLine("You didn't choose anything!");
}
else
{
    Console.WriteLine($"You chose: {response}");
}