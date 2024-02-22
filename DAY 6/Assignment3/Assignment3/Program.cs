// Method to generate an array of specified length

using Assignment3;

PracticeMethod pm = new PracticeMethod();
// int[] numbers = pm.GenerateNumbers(10); // Generate an array of 10 numbers
// pm.Reverse(numbers); // Reverse the array
// pm.PrintNumbers(numbers); // Print the reversed array

// Console.WriteLine("Input a number");
// int i = int.Parse(Console.ReadLine());
// Console.WriteLine($"Fibonacci({i}) = {pm.Fibonacci(i)}");

// Instructor instructor = new Instructor();
// Student student = new Student();
// instructor.Salary = 5000;
// instructor.YearsOfExperience = 5;
// instructor.BonusSalary = 300;
// Console.WriteLine($"Instudetor salary is: {instructor.Calculate()}");
// Dictionary<string, char> Grades = new Dictionary<string, char>
// {
//     { "Math", 'A' },
//     { "Science", 'B' },
//     { "History", 'C' },
//     // Add more grades as needed
// };
// student.Grades = Grades;
// Console.WriteLine($"Student grade is: {student.Calculate()}");



// Create a few colors for balls
Color redColor = new Color(255, 0, 0);
Color greenColor = new Color(0, 255, 0);
Color blueColor = new Color(0, 0, 255);

// Create a few balls with different sizes and colors
Ball ball1 = new Ball(10, redColor);
Ball ball2 = new Ball(15, greenColor);
Ball ball3 = new Ball(20, blueColor);

// Throw the balls around a few times
for (int i = 0; i < 3; i++)
{
    ball1.Throw();
    ball2.Throw();
    ball3.Throw();
}

// Pop one of the balls
ball2.Pop();

// Try to throw the popped ball
ball2.Throw(); // This shouldn't increment throw count

// Print out the throw count for each ball
Console.WriteLine("Ball 1 throw count: " + ball1.GetThrowCount());
Console.WriteLine("Ball 2 throw count: " + ball2.GetThrowCount());
Console.WriteLine("Ball 3 throw count: " + ball3.GetThrowCount());














