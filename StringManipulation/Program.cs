// See https://aka.ms/new-console-template for more information

string firstName = "Davi";
string lastName = "Oliveira";
DateTime date = DateTime.Now;

// Print to string
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine("My full name is " + firstName + " Augusto De " + lastName);
Console.WriteLine($"My full name is {firstName} Augusto De {lastName}");

// String length
int firstNameLength = firstName.Length;
int lastNameLength = lastName.Length;

Console.Write($"The length of the first name is {firstNameLength}, ");
Console.WriteLine($"and the length of the last name is {lastNameLength}");

// Replace string parts
string newName = firstName.Replace('D', 'B');
Console.WriteLine(newName);

// Append to other string variable
string fullName = $"{firstName} Augusto De {lastName}";
Console.WriteLine($"My name is {fullName}");

// Split String
string[] splitName = fullName.Split('a');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// Compare Strings
int comparisonResult = String.Compare(firstName, lastName);
Console.WriteLine(comparisonResult);

// Convert to String
string lowerCase = firstName.ToLower();
string upperCase = firstName.ToUpper();
Console.WriteLine(lowerCase);
Console.WriteLine(upperCase);