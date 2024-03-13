using System;

namespace BetterDecorator
{
    /// <summary>
    /// Programa para decorar uma string com um caractere específico.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal do programa.
        /// </summary>
        /// <param name="args">Argumentos da linha de comando.</param>
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else if (args.Length == 3)
            {
                string inputString = args[0];
                string decorationChar = args[1];
                int decorationCount = 0;

                if (!int.TryParse(args[2], out decorationCount))
                {
                    Console.WriteLine("Third argument must be an integer.");
                    return;
                }

                string decoratedString = Decor(inputString, decorationChar[0], decorationCount);
                Console.WriteLine(decoratedString);
            }
            else
            {
                Console.WriteLine("Usage: dotnet run --project BetterDecorator -- <string> <char> <int>");
            }
        }

        /// <summary>
        /// Método para decorar uma string com um caractere específico.
        /// </summary>
        /// <param name="input">String a ser decorada.</param>
        /// <param name="decorationChar">Caractere de decoração.</param>
        /// <param name="decorationCount">Número de vezes que o caractere deve aparecer de cada lado.</param>
        /// <returns>String decorada.</returns>
        static string Decor(string input, char decorationChar, int decorationCount)
        {
            string decoration = new string(decorationChar, decorationCount);
            string decorationString = decoration.PadRight(decoration.Length * 2 + input.Length, decorationChar);
            return $"{decorationString} {input} {decorationString}";
        }

        /// <summary>
        /// Método para decorar uma string com uma mensagem padrão.
        /// </summary>
        /// <returns>String decorada com a mensagem padrão.</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
