using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int specialNumber = GetSpecial(n);
                Console.WriteLine(specialNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        private static int GetSpecial(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return 2 * GetSpecial(n - 1) + GetSpecial(n - 2);
        }
    }
}
