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

            Console.WriteLine("Task 2: Factorial Number");
            Console.WriteLine("Enter a number:");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(f));
            // Task 2: Factorial Number
            // Write a recursive function to calculate the factorial of a given number. The factorial 
            // of a non - negative integer n is the product of all positive integers less than or equal
            // to n.
            static int Factorial(int n)
            {
                if (n == 0) { return 1; }

                else { return n * Factorial(n - 1); }
            }

            Console.WriteLine("Task 3: palindrome checker");
            Console.WriteLine("Enter a word to check of it is palindrome or not::");
            string p = Console.ReadLine();
            Console.WriteLine(IsPalindrome(p));
            // Task 3: palindrome checker
            // Write a recursive function to check if a given string is a palindrome.
            // A palindrome is a word, phrase, number, or other sequence of characters
            // that reads the same forward and backward.
            static bool IsPalindrome (string? p) 
            {
                if (p.Length <= 1)
                {
                    return true;
                }
                return p[0] == p[p.Length - 1] && IsPalindrome(p.Substring(1, p.Length - 2));
            }


        }
        
    }
}