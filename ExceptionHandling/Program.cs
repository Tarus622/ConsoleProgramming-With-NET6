// See https://aka.ms/new-console-template for more information

/*
    try - a block attempts an operation
    catch - catch any fatal error or exception 
    finally - wheter the try or the catch was sucessful, do this
    throw - end program execution with the error
*/

Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    int quotient = num1 / num2;
    Console.WriteLine($"Result is {quotient.ToString()}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Illegal operation: {ex.Message}");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("This is the end of the program");
}

