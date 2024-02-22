namespace Assignment3;

public class Student : Person
{
    public List<string> Courses { get; set; }
    public Dictionary<string, char> Grades { get; set; }

    // Polymorphism: Override method for calculating GPA
    public override decimal Calculate()
    {
        // Calculate GPA based on grades
        // Assuming grades are stored as 'A', 'B', 'C', 'D', 'F'
        decimal totalPoints = 0;
        foreach (var grade in Grades.Values)
        {
            switch (grade)
            {
                case 'A':
                    totalPoints += 4;
                    break;
                case 'B':
                    totalPoints += 3;
                    break;
                case 'C':
                    totalPoints += 2;
                    break;
                case 'D':
                    totalPoints += 1;
                    break;
                // 'F' has no points
            }
        }

        return totalPoints / Grades.Count;
    }
}