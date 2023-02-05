using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Intersys
{
    public static class Ex
    {
        public static void Ex1()
        {

            Console.WriteLine("Please provide array size");
            var input = int.TryParse(Console.ReadLine(), out int arraySize);

            int[] inputArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                inputArray[i] = i;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"\n{i + 1}");
            }
            Console.WriteLine("\nThis is your input array, please press any key to reverse it");
            Console.ReadKey();

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"\n{i + 1}");
            }

            Console.ReadKey();
        }

        public static void Ex2()
        {
            Console.WriteLine("Please provide a text");
            var userInput = Console.ReadLine().ToLower();


            List<char> inputChars = new List<char>();
            inputChars.AddRange(userInput);
            var finalstring = string
                .Concat(inputChars
                .Where(char.IsLetter))
                .ToCharArray();

            Console.WriteLine(finalstring);
            for (int i = finalstring.Length - 1; i >= 0; --i)
            {
                Console.Write(finalstring[i]);
            }

            bool isPalindrome = finalstring.SequenceEqual(finalstring.Reverse());

            Console.WriteLine($"\n{isPalindrome}");

        }
  
    }
}
