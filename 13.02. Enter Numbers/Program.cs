namespace _13._02._Enter_Numbers
{
    internal class Program
    {
        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                throw new Exception("Invalid Number!");
            }

            if (number <= start || number >= end)
            {
                throw new Exception($"Your number is not in range {start} - {end}!");
            }

            return number;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    numbers[i] = ReadNumber(i < 1 ? 1 : numbers[i - 1], 100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--; // Decrement i to re-enter the current number
                }
            }

            Console.WriteLine($"{string.Join(", ", numbers)}");
        }
    }
}