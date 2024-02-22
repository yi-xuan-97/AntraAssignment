namespace Assignment1;

public class PracticeArray
{
    public void PrintArr()
    {
        // Create the initial array with 10 items
        int[] originalArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Print the contents of the original array
        Console.WriteLine("Original Array:");
        PrintArray(originalArray);

        // Create a second array with the same length as the original array
        int[] copiedArray = new int[originalArray.Length];

        // Copy values from the original array to the new array
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

        // Print the contents of the copied array
        Console.WriteLine("\nCopied Array:");
        PrintArray(copiedArray);
    }
    private void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }

    public void ManageList()
    {
        List<string> itemList = new List<string>(); // Initialize an empty list to store items

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();

            if (input.StartsWith("+"))
            {
                // Add item to the list
                string itemToAdd = input.Substring(1).Trim();
                itemList.Add(itemToAdd);
            }
            else if (input == "--")
            {
                // Clear the list
                // itemList = new List<string>();
                itemList.Clear();
            }
            else if (input.StartsWith("-"))
            {
                // Remove item from the list
                string itemToRemove = input.Substring(1).Trim();
                itemList.Remove(itemToRemove);
            }
            
            else
            {
                Console.WriteLine("Invalid command. Please start with '+' to add, '-' to remove, or '--' to clear.");
            }

            // Print the current contents of the list
            Console.WriteLine("\nCurrent List:");
            if (itemList.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                foreach (string item in itemList)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
        }
    }



    public  int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primesList = new List<int>();

        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primesList.Add(num);
            }
        }

        return primesList.ToArray();
    }

    private  bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    public void RotateAndSumArray(int[] array, int k)
    {
        int n = array.Length;
        int[] sum = new int[n];

        for (int r = 1; r <= k; r++)
        {
            int[] rotatedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotatedArray[(i + 1) % n] = array[i];
            }

            array = rotatedArray;
            
            for (int i = 0; i < n; i++)
            {
                sum[i] += array[i];
            }
        }

        Console.WriteLine("Sum after each rotation:");
        foreach (int value in sum)
        {
            Console.Write(value + " ");
        }
    }


    public int[] FindLongestSequence(int[] array)
    {
        int maxLength = 0;
        int maxStartIndex = 0;

        int currentLength = 1;
        int currentStartIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = currentStartIndex;
                }

                currentStartIndex = i;
                currentLength = 1;
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxStartIndex = currentStartIndex;
        }

        return array.Skip(maxStartIndex).Take(maxLength).ToArray();
    }


    public List<int> FindMostFrequentNumber(int[] sequence)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in sequence)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        int maxFrequency = frequencyMap.Values.Max();
        List<int> mostFrequentNumbers = frequencyMap.Where(x => x.Value == maxFrequency)
            .Select(x => x.Key)
            .ToList();

        return mostFrequentNumbers;
    }
    
    
}