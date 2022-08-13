// See https://aka.ms/new-console-template for more information

// Empty DateTime
DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1998, 09, 10, 10, 00, 00);
Console.WriteLine($"My birthday was in {dateOfBirth}");

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"The time now is: {now}");

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("10/09/1998");
Console.WriteLine($"Date from string is: {dateFromString}");

// Add Aditional Time
Console.WriteLine($"One hour from now is: {now.AddHours(1)}");
Console.WriteLine($"One day from now is: {now.AddDays(1)}");
Console.WriteLine($"One month from now is: {now.AddMonths(1)}");
Console.WriteLine($"One year from now is: {now.AddYears(1)}");

// DateTime from Ticks
Console.WriteLine($"Time as a numeral: {now.Ticks}");

// Date only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine($"My birthday was in {dateOnlyOfBirth}");

// Time only
TimeOnly timeOnly = TimeOnly.FromDateTime(dateOfBirth);
Console.WriteLine($"My birthday was at {timeOnly} o'clock");

