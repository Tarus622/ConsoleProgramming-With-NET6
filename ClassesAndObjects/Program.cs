// See https://aka.ms/new-console-template for more information

Person person = new();
string middleName = string.Empty;
DateTime yearOfBirth = DateTime.MinValue;

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Middle Name: ");
middleName = Console.ReadLine();

Console.WriteLine("Enter Birthday: ");
person.Birthday = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter Salary: ");
double salary = Convert.ToDouble(Console.ReadLine());

person.setSalary(salary);

Console.WriteLine($"First Name is: {person.FirstName}");
Console.WriteLine($"Last Name is: {person.LastName}");
Console.WriteLine($"Full Name is: {person.getFullName(middleName)}");
Console.WriteLine($"Age is: {person.getAge()}");
Console.WriteLine($"Salary is: R${person.getSalary()}");

Console.WriteLine($"Your Year of Birth: {DateUtil.YearOfBirth(Convert.ToInt32(person.getAge()))}");

// static class removes the necessity of this instantiation
// DateUtil dateUtil = new DateUtil();
