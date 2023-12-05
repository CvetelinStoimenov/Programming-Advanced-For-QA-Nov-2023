using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;

        try
        {
            string[] elements = input.Split(' ');

            foreach (string element in elements)
            {
                try
                {
                    int currentNumber = ParseAndAddToSum(element, sum);
                    sum += currentNumber;
                    Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in the wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static int ParseAndAddToSum(string element, int currentSum)
    {
        int parsedNumber = int.Parse(element);
        checked
        {
            return currentSum + parsedNumber;
        }
    }
}
