using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: dotnet run --project BetterDecorator -- <string> <char> <int>");
                return;
            }

            string inputString = args[0];
            string decorationChar = args[1];
            int decorationCount = 0;

            if (!int.TryParse(args[2], out decorationCount))
            {
                Console.WriteLine("Third argument must be an integer.");
                return;
            }

        }

    }
}
