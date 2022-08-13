// See https://aka.ms/new-console-template for more information

// Declare Fixed Size Array
int[] grades = new int[5];
int[] numbers = {1, 5, 8, 5, 4};
// 5 spaces adresses - 0, 1, 2, 3, 4
// If n is the size of the array, then your array has adressed between 0 to n-1

// Add values to Fixed Size Array

/*grades[0] = 8;
grades[1] = 9;
grades[2] = 10;
grades[3] = 7;
grades[4] = 9;*/

//grades = new int[] { 1, 2, 2, 5, 4 };

for(int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
};

// Print values in Fixed Size Array
for (var i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"The grade of the test {i + 1} is {grades[i]}");
}

// Declare Variable Sized Array
string[] animals = new string[5] {"Elephant", "Tourtle", "Tiger", "Lion", "Bear"};

// Add values in Variable Sized Array
for (int i = 0; i < animals.Length; i++)
{
    Console.WriteLine("Enter Animal: ");
    animals[i] = Console.ReadLine();
};

// Print values in Variable Sized Array
for (var i = 0; i < animals.Length; i++)
{
    Console.WriteLine($"The animal of the position {i + 1} is {animals[i]}");
}
