namespace _13._01._Square_Roots
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new ArgumentException();
                }

                double result = Math.Sqrt(input);

                Console.WriteLine(result);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
