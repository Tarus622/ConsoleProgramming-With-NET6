// See https://aka.ms/new-console-template for more information

// Declare
List<string> names = new List<string>();
string name = string.Empty;

// Add values to a list
names.Add("Davi");

while(name != "-1")
{
    Console.WriteLine("Enter Name: ");
    name = Console.ReadLine();
    if(!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
    }
}

// Print values in list
Console.WriteLine("Print names via for loop");
for(int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Print names via foreach loop");
foreach(string n in names)
{
    Console.WriteLine(n);
}
