namespace cSharp_Recursion_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Fibonacci number");
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
            // Task 1:
            // Create a recursive function to calculate the nth Fibonacci number. The Fibonacci
            // sequence is a series of numbers in which each number is the sum of the two
            // preceding ones: 0, 1, 1, 2, 3, 5, 8, ...
            static int Fibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }

        }
    }
}