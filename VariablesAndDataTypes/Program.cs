// See https://aka.ms/new-console-template for more information

// Variable Declarations and Types
string name = string.Empty;
int age = 0;
double salary = 0;
char gender = char.MinValue;
bool working = false;

// Prompt User for Input
Console.Write("Please, enter your name: ");
name = Console.ReadLine();

Console.Write("Please, enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false)?");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine($"Your name is {name}, you have {age} years, your salary is ${salary} dolars, your gender is {gender}.");