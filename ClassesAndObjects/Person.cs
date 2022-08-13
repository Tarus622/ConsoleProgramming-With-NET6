// See https://aka.ms/new-console-template for more information

// Primitive datatypes
//// int, string, char, bool

// Object Oriented Programing - Creating your own datatypes
// Class - blueprint

// Single Responsability Principle 


public class Person
{
    // Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }

    // Fields
    private double _salary { get; set; }

    public void setSalary(double salary)
    {
        _salary = salary;
    }
   
    public double getSalary()
    {
        return _salary;
    }
    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }
    public string getFullName(string middleName)
    {
        if(string.IsNullOrEmpty(middleName))
        {
            return $"{FirstName} {LastName}";
        } 
        else
        {
            return $"{FirstName} {middleName} {LastName}";

        }
    }
    public long getAge()
    {
        long num = Convert.ToInt64(Birthday.Ticks);
        long now = Convert.ToInt64(DateTime.Now.Ticks);
        return (now - num) / 315360000000000;
    }
}




