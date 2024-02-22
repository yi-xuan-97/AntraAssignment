namespace Assignment1;

public class LoopNOperator
{
    public void FizzBuzzis()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        
        /*
         * int max = 500;
           for (byte i = 0; i < max; i++)
           {
               Console.WriteLine(i);
           }
           This code will cause infinite loop. i will overflow to 0 when reaching 255
           This code block can be added to fix the issue:
           
           if (i == byte.MaxValue) // Check if i has reached its maximum value
           {
               Console.WriteLine("Warning: Byte overflow may cause infinite loop!");
               break; // Break out of the loop to prevent infinite execution
           }
           
         */
    }

    public void RandomeNum()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4); // Generates a random number between 1 and 3

        while (true)
        {
            Console.WriteLine("Guess the number between 1 and 3:");
            int guessedNumber;

            try
            {
                guessedNumber =
                    int.Parse(Console.ReadLine()); // Convert the user's typed answer from a string to an int
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Go back to the beginning of the loop to ask for input again
            }

            // Check if the user's guess is within the valid range
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range of numbers.");
                continue; // Go back to the beginning of the loop to ask for input again
            }

            // Compare the user's guess with the random number
            if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                break; // Exit the loop as the user has guessed the correct number
            }
        }
    }

    public void PrintStar()
    {
        int rows = 5; // Number of rows in the pyramid

        // Outer loop for each row
        for (int i = 0; i < rows; i++)
        {
            // Inner loop for spaces before the stars
            for (int j = 0; j < rows - i - 1; j++)
            {
                Console.Write(" ");
            }

            // Inner loop for printing stars
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Move to the next line after printing each row
        }
    }

    public void CalculateAgeNSalary()
    {
        // Define the birth date of the person
        DateTime birthDate = new DateTime(1990, 5, 15); // Example birth date: May 15, 1990

        // Calculate the age of the person in days
        TimeSpan ageInDays = DateTime.Today - birthDate;

        // Output the age of the person in days
        Console.WriteLine($"The person is {ageInDays.TotalDays:N0} days old.");

        // Calculate the date of their next 10,000 day anniversary
        int daysToNextAnniversary = 10000 - ((int)ageInDays.TotalDays % 10000);
        DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);

        // Output the date of their next 10,000 day anniversary
        Console.WriteLine($"The next 10,000 day anniversary will be on: {nextAnniversary:d}");
    }

    public void Greeting()
    {
        // Get the current time
        DateTime currentTime = DateTime.Now;

        // Extract the hour from the current time
        int currentHour = currentTime.Hour;

        // Define the time ranges for each greeting
        if (currentHour >= 0 && currentHour < 12)
        {
            Console.WriteLine("Good Morning");
        }

        if (currentHour >= 12 && currentHour < 17)
        {
            Console.WriteLine("Good Afternoon");
        }

        if (currentHour >= 17 && currentHour < 20)
        {
            Console.WriteLine("Good Evening");
        }

        if (currentHour >= 20 || currentHour < 4)
        {
            Console.WriteLine("Good Night");
        }
    }

    public void PrintNum()
    {
        for (int increment = 1; increment <= 4; increment++)
        {
            Console.WriteLine($"Counting by {increment}s:");

            for (int i = 0; i <= 24; i += increment)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}