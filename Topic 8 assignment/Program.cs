namespace Topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment one
            Console.WriteLine("Assignment one - Reading in Colours");
            Console.WriteLine();
            List<string> colours = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a colour: ");
                colours.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", colours));
        }
    }
}
