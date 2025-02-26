namespace Part_6___Loops_Assignment
{
    internal class Program
    {
        public static void Prompt()
        {
            int min, max, userNum;
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Hello! Please enter a min and a max number:");
                while (!Int32.TryParse(Console.ReadLine(), out min) || !Int32.TryParse(Console.ReadLine(), out max))
                    Console.WriteLine("Invalid Integer, Please Try Again:");

                while (min >= max)
                {
                    Console.WriteLine();
                    Console.WriteLine("Min Number cannot be bigger than, (or the same as), the Max Number. Please Try Again:");
                    while (!Int32.TryParse(Console.ReadLine(), out min) || !Int32.TryParse(Console.ReadLine(), out max))
                        Console.WriteLine("Invalid Integer, Please Try Again:");
                }
                while (min < 0 || max < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Min and/or Max Number cannot be negative. Please Try Again:");
                    while (!Int32.TryParse(Console.ReadLine(), out min) || !Int32.TryParse(Console.ReadLine(), out max))
                        Console.WriteLine("Invalid Integer, Please Try Again:");
                }

                Console.WriteLine();
                Console.WriteLine($"You choose {min} through {max}.");
                Console.WriteLine("Now, choose a number between that range of numbers.");
                while (!Int32.TryParse(Console.ReadLine(), out userNum))
                    Console.WriteLine("Invalid Integer. Please Try Again:");

                while (userNum < min || userNum > max)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your Number cannot be smaller than the Min Number, or bigger than the Max Number.");
                    Console.WriteLine("Please Try Again:");
                    while (!Int32.TryParse(Console.ReadLine(), out userNum))
                        Console.WriteLine("Invalid Integer. Please Try Again:");
                }
                while (userNum < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your Number cannot be negative. Please Try Again:");
                    while (!Int32.TryParse(Console.ReadLine(), out userNum))
                        Console.WriteLine("Invalid Integer. Please Try Again:");
                }

                Console.WriteLine();
                Console.WriteLine($"Your number is {userNum}. Good Job!"); 
            }

        }
        public static void Bank()
        {

        }
        public static void DoubleDice()
        {
            decimal userMoney = 150.00M, deposit, withdrawal;
            string choice = "";
            bool quit = false;

            while (!quit)
            {
                Console.WriteLine($"Welcome to the BoB ATM. You currently have ${userMoney}. Please select one of the options:");
                Console.WriteLine("(Remember that every Transaction you make costs $0.75 each)");
                Console.WriteLine();
                Console.WriteLine("- Deposit");
                Console.WriteLine("- Withdrawal");
                Console.WriteLine("- Bill Payment");
                Console.WriteLine("- Account Balance Update");
                Console.WriteLine("- Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "deposit")
                {
                    userMoney = userMoney - 0.75M;
                    Console.WriteLine($"You currently have ${userMoney}. How much would you like to deposit?");
                    Console.WriteLine();
                    while (!Decimal.TryParse(Console.ReadLine(), out deposit))
                        Console.WriteLine("Invalid Integer, please try again:");
                    while (deposit < 0)
                    {
                        Console.WriteLine("Invalid Integer, please try again:");
                        while (!Decimal.TryParse(Console.ReadLine(), out deposit))
                            Console.WriteLine("Invalid Integer, please try again:");
                    }
                    userMoney = userMoney + deposit;
                    Console.WriteLine("Thank you for Depositing!");
                }
                else if (choice == "withdrawal")
                {
                    userMoney = userMoney - 0.75M;
                    Console.WriteLine($"You currently have ${userMoney}. How much would you like to withdrawal?");
                    Console.WriteLine();
                    while (!Decimal.TryParse(Console.ReadLine(), out withdrawal))
                        Console.WriteLine("Invalid Integer, please try again:");
                    while (withdrawal < 0)
                    {
                        Console.WriteLine("Invalid Integer, please try again:");
                        while (!Decimal.TryParse(Console.ReadLine(), out deposit))
                            Console.WriteLine("Invalid Integer, please try again:");
                    }
                    while (withdrawal > userMoney)
                    {
                        Console.WriteLine("You cannot withdrawal more than what you own, please try again:");
                        while (!Decimal.TryParse(Console.ReadLine(), out deposit))
                            Console.WriteLine("Invalid Integer, please try again:");
                    }
                    while (withdrawal == userMoney)
                    {
                        Console.WriteLine("You need enough to pay for the transaction fee, please try again:");
                        while (!Decimal.TryParse(Console.ReadLine(), out deposit))
                            Console.WriteLine("Invalid Integer, please try again:");
                    }
                    userMoney = userMoney - withdrawal;
                    Console.WriteLine("Thank you for Withdrawaling!");
                }
            }
        }
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
                    Prompt();
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
                    Console.WriteLine("Press Enter to Go Back");
                    Console.ReadLine();
                }

            }
        }
    }
}
