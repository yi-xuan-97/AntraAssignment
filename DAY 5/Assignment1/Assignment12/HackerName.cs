namespace Assignment1;

public class HackerName
{
    public void GenerateName()
    {
        // Ask the user for their favorite color
        Console.WriteLine("What is your favorite color?");
        string favoriteColor = Console.ReadLine();

        // Ask the user for their astrology sign
        Console.WriteLine("What is your astrology sign?");
        string astrologySign = Console.ReadLine();

        // Ask the user for their street address number
        Console.WriteLine("What is your street address number?");
        string addressNumberInput = Console.ReadLine();

        // Parse the street address number as an integer
        if (!int.TryParse(addressNumberInput, out int addressNumber))
        {
            Console.WriteLine("Invalid address number. Please enter a valid integer.");
            return; // Exit the program if the address number is invalid
        }

        // Generate the hacker name using the provided information
        string hackerName = $"{favoriteColor}{astrologySign}{addressNumber}";

        // Display the hacker name to the user
        Console.WriteLine($"Your hacker name is {hackerName}.");
    }
}