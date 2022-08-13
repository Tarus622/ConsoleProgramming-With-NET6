Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Hight: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Hypotenuese: ");
int hypotenuese = Convert.ToInt32(Console.ReadLine());

// Assigning values using the constructor method
var cube = new Cube(length);
var rectangle = new Rectangle(width, length); 
var triangle = new Triangle(height, length);

// Assigning values without the constructor method
/*
cube.Length = length;

triangle.Length = length;
triangle.Height = height;
triangle.Hypotenuese = hypotenuese;

rectangle.Width = width;
rectangle.Length = length;
*/

Console.WriteLine($"Cube area is: {cube.GetArea()}");
Console.WriteLine($"Cube volume is: {cube.GetVolume()}");

Console.WriteLine($"Triangle area is: {triangle.GetArea()}");

Console.WriteLine($"Rectangle area is: {rectangle.GetArea()}");