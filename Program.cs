namespace Part_6___Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            string choice = "";

            while (!quit)
            {
                Console.WriteLine("Welcome back to the most copy-paste menu ever!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1. Prompting Time");
                Console.WriteLine("2. Using an ATM");
                Console.WriteLine("3. Double Dice");
                Console.WriteLine("Q. Leave, I guess.");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Go Back");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Go Back");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Go Back");
                    Console.ReadLine();
                }
                else if (choice == "q")
                {
                    quit = true;
                    Console.WriteLine();
                    Console.WriteLine("Alright, cya. Bye bye.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That's not an option, silly goose.");
                }

            }
        }
    }
}
