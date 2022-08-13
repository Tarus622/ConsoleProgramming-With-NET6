// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter First Nummber: ");
int numOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number: ");
int numOfOranges = Convert.ToInt32(Console.ReadLine());


// If Statements
if (numOfApples > numOfOranges)
{
    Console.WriteLine($"You have {numOfApples - numOfOranges} more apples than oranges");
}
else if (numOfApples < numOfOranges)
{
    Console.WriteLine($"You have {numOfOranges - numOfApples} more oranges than apples");
}
else
{
    Console.WriteLine($"The number o apples and oranges are the same");
}

// Switch Statements
Console.WriteLine("Enter your grade:");
int grade = Convert.ToInt32(Console.ReadLine());

switch(grade)
{
    case int n when n < 7 && n >= 0: Console.WriteLine("Reproved");
        break;
    case int n when n <= 10 && n >= 7: Console.WriteLine("Aproved");
        break;
    default: Console.WriteLine("Invalid value");
        break;
}

// Ternary
var message = numOfApples > numOfOranges ? "You have more apples" : "You don't have more apples";
Console.WriteLine(message);