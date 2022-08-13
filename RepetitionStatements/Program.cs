// See https://aka.ms/new-console-template for more information

// For Loop (Counter Controlled)
for (int counter = 0; counter < 10; counter++)
{
    Console.WriteLine($"The counter value is {counter}");
}

// While Loop (Condition Controlled - Pre Check)
/*
int number = 0;
while (number < 10)
{
    Console.WriteLine("Enter the number: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {number}");
}
*/

// Do... While Loop (Condition Controlled - Post Check)
int number = 0;
do
{
    Console.WriteLine("Enter the number: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {number}");
} while (number < 10);

// ForEach - Hounorable Mention
string[] collection = new string [5] {"Turtle", "Lion", "Tiger", "Elephant", "Whale"};
foreach(string item in collection)
{
    Console.WriteLine(item);
}