using System.Runtime.CompilerServices;

namespace Topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int max, min, numbersNeeded;

            //Assignment one
            //Console.WriteLine("Assignment one - Reading in Colours");
            //Console.WriteLine();
            //List<string> colours = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Please enter a colour: ");
            //    colours.Add(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine(string.Join(", ", colours));
            //Console.WriteLine();
            //Console.WriteLine(colours[generator.Next(0, 6)]);
            //Console.ReadLine();
            //Console.Clear();

            //Assignment two
            Console.WriteLine("Assignment two - Random Numbers");
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
        }
    }
}
