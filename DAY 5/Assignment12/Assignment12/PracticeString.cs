using System.Text.RegularExpressions;

namespace Assignment1;

public class PracticeString
{
    public string ReverseStringMethod1(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Method 2: Print the letters of the string in back direction (from the last to the first) in a for-loop
    public string ReverseStringMethod2(string input)
    {
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        return reversed;
    }

    public string ReverseWords(string sentence)
    {
        // Define the pattern to match words and separators
        string pattern = @"([.,:;=()&\[\]""'\\\/!?\s]+)";
        Regex r = new Regex("^[a-zA-Z0-9]*$");

        // Split the sentence into words and separators
        string[] wordsAndSeparators = Regex.Split(sentence, pattern);
        
        int length = wordsAndSeparators.Length - 1;
        // Reverse the array of words only
        int i = 0, j = length - 1;
        while(i<j)
        {
            if(r.IsMatch(wordsAndSeparators[i]) && r.IsMatch(wordsAndSeparators[j]))
            {
                (wordsAndSeparators[i], wordsAndSeparators[j]) = (wordsAndSeparators[j], wordsAndSeparators[i]);
                ++i;
                --j;
            }
            else if(r.IsMatch(wordsAndSeparators[i]))
            {
                --j;
            }
            else
            {
                ++i;
            }
        }

        // Concatenate the reversed words and separators
        return string.Concat(wordsAndSeparators);
    }


    public List<string> ExtractPalindromes(string text)
    {
        // Define the pattern to match words
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        HashSet<string> palindromesSet = new HashSet<string>();

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromesSet.Add(word);
            }
        }

        // Convert the set to a list and sort it
        List<string> palindromesList = palindromesSet.ToList();
        palindromesList.Sort();

        return palindromesList;
    }

    private bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public URLParts ParseURL(string url)
    {
        URLParts urlParts = new URLParts();

        // Find the index of the server part
        int serverIndex = url.IndexOf("://");

        if (serverIndex != -1)
        {
            // Extract the protocol
            urlParts.Protocol = url.Substring(0, serverIndex);

            // Remove the protocol part from the URL
            url = url.Substring(serverIndex + 3);
        }

        // Find the index of the resource part
        int resourceIndex = url.IndexOf('/');

        if (resourceIndex != -1)
        {
            // Extract the server
            urlParts.Server = url.Substring(0, resourceIndex);

            // Extract the resource
            urlParts.Resource = url.Substring(resourceIndex + 1);
        }
        else
        {
            // If there is no resource part, the remaining part is the server
            urlParts.Server = url;
        }

        return urlParts;
    }
    
}

public class URLParts
{
    public string Protocol { get; set; } = "";
    public string Server { get; set; } = "";
    public string Resource { get; set; } = "";
}
