using Assignment1;

HackerName hk = new HackerName();
// hk.GenerateName();

NumSizeNRange nsr = new NumSizeNRange();
// nsr.OutputRange();
// nsr.TimeOutput();

LoopNOperator lno = new LoopNOperator();
// lno.FizzBuzzis();
// lno.RandomeNum();
// lno.PrintStar();
// lno.CalculateAgeNSalary();
// lno.Greeting();
// lno.PrintNum();

PracticeArray pr = new PracticeArray();
// pr.PrintArr();
// pr.ManageList();

// int startNum = 1;
// int endNum = 100;
//
// int[] primes = pr.FindPrimesInRange(startNum, endNum);
//
// Console.WriteLine("Prime numbers between {0} and {1}:", startNum, endNum);
// foreach (int prime in primes)
// {
//     Console.Write(prime + " ");
// }


// Console.WriteLine("Enter the array of integers separated by spaces:");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//
// Console.WriteLine("Enter the value of k:");
// int k = int.Parse(Console.ReadLine());
//
// pr.RotateAndSumArray(array, k);


// Console.WriteLine("Enter the array of integers separated by spaces:");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//
// int[] longestSequence = pr.FindLongestSequence(array);
//
// Console.WriteLine("Longest sequence of equal elements:");
// Console.WriteLine(string.Join(" ", longestSequence));


// Console.WriteLine("Enter the sequence of numbers separated by spaces:");
// int[] sequence = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//
// List<int> mostFrequentNumbers = pr.FindMostFrequentNumber(sequence);
//
// Console.WriteLine("Most frequent numbers in the sequence:");
// Console.WriteLine(string.Join(" ", mostFrequentNumbers));


PracticeString ps = new PracticeString();

// Console.WriteLine("Enter a string:");
// string input = Console.ReadLine();
//
// string reversed1 = ps.ReverseStringMethod1(input);
// string reversed2 = ps.ReverseStringMethod2(input);
//
// Console.WriteLine("Reversed string using Method 1: " + reversed1);
// Console.WriteLine("Reversed string using Method 2: " + reversed2);


// Console.WriteLine("Enter a sentence:");
// string sentence = Console.ReadLine();
//
// string reversedSentence = ps.ReverseWords(sentence);
//
// Console.WriteLine("Reversed sentence:");
// Console.WriteLine(reversedSentence);


// Console.WriteLine("Enter a text:");
// string text = Console.ReadLine();
//
// List<string> palindromes = ps.ExtractPalindromes(text);
//
// Console.WriteLine("Palindromes:");
// Console.WriteLine(string.Join(", ", palindromes));


Console.WriteLine("Enter the URL:");
string url = Console.ReadLine();

URLParts urlParts = ps.ParseURL(url);

Console.WriteLine("Protocol: " + urlParts.Protocol);
Console.WriteLine("Server: " + urlParts.Server);
Console.WriteLine("Resource: " + urlParts.Resource);



