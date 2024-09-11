namespace UnitTestPractice;

public class MethodsForTesting
{
    
    // Test a string reversal method:
    // Implement a ReverseString(string input) method and write tests to 
    // ensure it correctly reverses input strings.
    public string ReverseString(string input)
    {
        if (input == null) return null;
        var charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
    // Test a method that checks if a number is even:
    // Create an IsEven(int number) method and write tests to verify it 
    // correctly identifies even and odd numbers.

    public bool IsEven(int input)
    {
        return input % 2 == 0;
    }
    
    // Test a method that finds the maximum value in an array:
    // Implement a FindMax(int[] numbers) method and write tests to 
    // ensure it finds the maximum value correctly.

    public int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array must not be null or empty.");

        }
        return numbers.Max();
    }
    
    // Test a method that counts the occurrences of a character in a string:
    // Create a CountOccurrences(string input, char character) method and write
    // tests to verify it counts characters correctly.

    public int CountOccurences(string input, char character)
    {

        if (input == null) return 0;
        return input.Count(c => c == character);
    }
    
    
    // Test a method that removes duplicates from an array:
    // Implement a RemoveDuplicates(int[] numbers) method and write tests
    // to verify it correctly removes duplicate elements.

    public int[] RemoveDuplicates(int[] numbers)
    {
        if (numbers ==null) return null;
        return numbers.Distinct().ToArray();
    }
    
    
}