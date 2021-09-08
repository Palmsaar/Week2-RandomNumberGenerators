using System;

namespace Rock__Paper__scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your opponents name.");
            string ComputerName = Console.ReadLine();           
            int ComputerWins = 0;
            int UserWins = 0;
            while (ComputerWins < 2 && UserWins < 2)
            {
                Console.WriteLine("Please enter Paper, Rock, Scissors.");
                string Userchoice = Console.ReadLine().ToLower();
                Random rnd = new Random();
                int ComputerChoice = rnd.Next(1, 4);
                if (Userchoice == "paper" && ComputerChoice == 3)
                {
                    Console.WriteLine($"{ComputerName} wins with scissors against paper!");
                    ComputerWins++;
                }
                else if (Userchoice == "rock" && ComputerChoice == 3)
                {
                    Console.WriteLine($"{ComputerName} Loses with scissors against rock!");
                    UserWins++;
                }
                else if (Userchoice == "scissors" && ComputerChoice == 3)
                {
                    Console.WriteLine($"It's a draw with both choosing scissors!");

                }
                else if (Userchoice == "paper" && ComputerChoice == 2)
                {
                    Console.WriteLine($"{ComputerName} loses with rock against paper!");
                    UserWins++;
                }
                else if (Userchoice == "rock" && ComputerChoice == 2)
                {
                    Console.WriteLine($"It's a draw with both choosing rock!");

                }
                else if (Userchoice == "scissors" && ComputerChoice == 2)
                {
                    Console.WriteLine($"{ComputerName} wins with rock against scissors!");
                    ComputerWins++;
                }
                else if (Userchoice == "paper" && ComputerChoice == 1)
                {
                    Console.WriteLine($"It's a draw with both choosing paper!");

                }
                else if (Userchoice == "rock" && ComputerChoice == 1)
                {
                    Console.WriteLine($"{ComputerName} wins with paper against rock!");
                    ComputerWins++;
                }
                else if (Userchoice == "scissors" && ComputerChoice == 1)
                {
                    Console.WriteLine($"{ComputerName} loses with paper against scissors!");
                    UserWins++;
                }               

            }
            if (ComputerWins < UserWins)
            {
                Console.WriteLine($"{ComputerName} loses {ComputerWins} to {UserWins}!");
            }
            else
            {
                Console.WriteLine($"{ComputerName} wins {ComputerWins} to {UserWins}!");
            }

            Console.ReadLine();
        }
    }
}
