// See https://aka.ms/new-console-template for more information

// Prototype - Defines the function (type, name and parameters)
// Definition - Has the code. It contain the code block
// Function Call - Makes the function
// DRY - Don't Repeat Yourself
// YAGNI - You Aren't Going To Need It


// Void Functions - Completes a task and moves along
void PrintName()
{
    Console.WriteLine("Davi Oliveira");
}

PrintName();

void Addition(float num1, float num2)
{
    float sum = num1 + num2;
    Console.WriteLine($"The sum between {num1} and {num2} is {sum}");
}
/*
Console.WriteLine("Enter the first number: ");
float number1 = float.Parse(s: Console.ReadLine());

Console.WriteLine("Enter the second number: ");
float number2 = float.Parse(s: Console.ReadLine());

Addition(number1, number2);
*/

// Value Returning Functions - Completes a task, returns a result

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if(largest < num2)
    {
        largest = num2;
    }

    if(largest < num3)
    {
        largest = num3;
    }

    return largest;
}

Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);

Console.WriteLine($"The largest number is {result}");

