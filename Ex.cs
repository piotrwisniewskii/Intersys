using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

            string final = isPalindrome ? "YES" : "NO";
            Console.WriteLine($"\n{final}");
        }
        public static void Ex3()
        {

            Console.WriteLine("Please provide numbers for the first array");

            int[] userArray1 = new int[11];

            for (int i = 0; i < 11; i++)
            {
                var input = int.TryParse(Console.ReadLine(), out int numberInput);
                userArray1[i] = numberInput;
            }

            Console.WriteLine("Please provide numbers for the second array");
            int[] userArray2 = new int[11];

            for (int i = 0; i < 11; i++)
            {
                var input = int.TryParse(Console.ReadLine(), out int numberInput);
                userArray2[i] = numberInput;
            }
            bool isPermutation = userArray2
                .OrderByDescending(x => x)
                .SequenceEqual(userArray1.OrderByDescending(x => x));
            string final = isPermutation ? "YES" : "NO";
            Console.WriteLine($"\n{final}");
        }

        public static void Ex4() //The excersize didnt specify if we want the numbers in the list to be unique or not
        {
            Console.WriteLine("Please provide numbers, simply provide 0 to finish the list");
            List<int> userList = new List<int>();

            do
            {
                var input = int.TryParse(Console.ReadLine(), out int userNumber);
                bool isPowerOfTwo = BitOperations.IsPow2(userNumber);
                bool isSqrtOfTwo = Math.Sqrt(userNumber) % 2 == 0;

                if (isPowerOfTwo)
                {
                    userList.Add(userNumber);
                    Console.WriteLine($"{userNumber} is a power of two, added to the list");
                    if (isSqrtOfTwo)
                    {
                        userList.Add((int)Math.Sqrt(userNumber));
                        Console.WriteLine($"Sqrt of {userNumber} == {(int)Math.Sqrt(userNumber)}, added to the list");
                    }
                }
                if (userNumber == 0)
                {
                    break;
                }

            } while (true);


            if (userList.Count == 0)
            {
                Console.WriteLine("NA");
            }
            else
            {
                Console.WriteLine("The Final list");
                foreach (var number in userList)
                {
                    Console.Write($"{number},");
                }
            }
        }

        public static void Ex5()
        {
            Console.WriteLine("Please provide the number of Tests");
            var input = double.TryParse(Console.ReadLine(), out double userNumber);
            double T, m, n, prime;

            for (int h = 0; h < userNumber; h++)
            {
                Console.WriteLine("\nEnter the first value m");
                m = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the second value n");

                n = double.Parse(Console.ReadLine());

                if (m - n > 1000000)
                {
                    Console.WriteLine($"the values are too high {m - n} is higher than 10^5");
                    return;
                }
                Console.WriteLine("\nPrime numbers between m and n are as follows:");

                for (double i = m; i <= n && i >= 1; i++)
                {
                    prime = 1;

                    for (double j = 2; j <= i / 2; ++j)
                    {
                        if (i % j == 0)
                        {
                            prime = 0;
                            break;
                        }
                    }
                    if (prime == 1)
                        Console.Write($"{i} ");
                }
            }

        }

        public static void Ex6(int a, int b)
        {
            string c;
            do
            {
                Console.WriteLine("\nEnter the first value a");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the second value b");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIf you want to raise the first argument to the power determined by the second argument write OK" +
                    "\n If you want to raise the second argument to the power determined by first argument write CANCEL");

                c = Console.ReadLine().ToUpper();


                switch (c)
                {
                    case "OK":
                        Console.WriteLine(Math.Pow(a, b));
                        break;

                    case "CANCEL":
                        Console.WriteLine(Math.Pow(a, b));
                        break;
                }
                
            } while (c != "OK" && c != "CANCEL");
        }

        public static void Ex7()
        {

        }
    }
}
