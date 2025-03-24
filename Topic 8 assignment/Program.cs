using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int max, min, numbersNeeded, userNumber, userNumberCount = 0, numberEqualZero;

            //Assignment one
            Console.WriteLine("Assignment one - Reading in Colours");
            Console.WriteLine();
            List<string> colours = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a colour: ");
                colours.Add(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", colours));
            Console.WriteLine();
            Console.WriteLine(colours[generator.Next(0, 6)]);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            //Assignment two
            Console.WriteLine("Assignment two - Random Numbers");
            Console.WriteLine();
            Console.WriteLine("Creating a list");
            Console.WriteLine();
            Console.WriteLine("How many numbers do you need?");
            int.TryParse(Console.ReadLine(), out numbersNeeded);
            Console.WriteLine();
            Console.WriteLine("What is the maximum value?");
            int.TryParse(Console.ReadLine(), out max);
            Console.WriteLine();
            Console.WriteLine("What is the minimum value?");
            int.TryParse(Console.ReadLine(), out min);
            Console.WriteLine();
            List<int> numbers = new List<int>();
            for (int i = 0; i < numbersNeeded; i++)
            {
                numbers.Add(generator.Next(min, (max + 1)));
            }

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.ReadLine();

            //Counting occurrences of a number chosen by the user
            Console.WriteLine("Counting occurrences of a number chosen by the user");
            Console.WriteLine();
            Console.WriteLine("Please enter an integer:");
            int.TryParse(Console.ReadLine(), out userNumber);
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == userNumber)
                {
                    userNumberCount += 1;
                }
            }
            Console.WriteLine(userNumber + " appears " + userNumberCount + " times");
            Console.WriteLine();
            Console.ReadLine();

            //Resetting a number chosen by the user to zero
            Console.WriteLine();
            Console.WriteLine("Resetting a number chosen by the user to zero");
            Console.WriteLine();
            Console.WriteLine("Please enter an integer:");
            int.TryParse(Console.ReadLine(), out numberEqualZero);
            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numberEqualZero)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.ReadLine();

            //Resetting everything to zero
            Console.WriteLine();
            Console.WriteLine("Resetting everything to zero");
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 0;
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.ReadLine();

            //Refilling the list with random numbers
            Console.WriteLine();
            Console.WriteLine("Refilling the list with random numbers");
            Console.WriteLine();
            for (int i = 0; i < numbersNeeded; i++)
            {
                numbers[i] = (generator.Next(min, (max + 1)));
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
