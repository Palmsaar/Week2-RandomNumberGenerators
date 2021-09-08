using System;

namespace Rock__Paper__scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your opponents name.");
            string Computername = Console.ReadLine();
            int i = 0;
            int Computerwins = 0;
            int UserWins = 0;
            while (i < 3)
            {
                Console.WriteLine("Please enter Paper, Rock, scissors.");
                string Userchoice = Console.ReadLine().ToLower();
                Random rnd = new Random();
                int ComputerChoice = rnd.Next(1, 4);
                if (Userchoice == "paper" && ComputerChoice == 3)
                {
                    Console.WriteLine($"{Computername} wins with scissors against paper!");
                    Computerwins++;
                }
                else if (Userchoice == "rock" && ComputerChoice == 3)
                {
                    Console.WriteLine($"{Computername} Loses with scissors against rock!");
                    UserWins++;
                }
                else if (Userchoice == "scissors" && ComputerChoice == 3)
                {
                    Console.WriteLine($"It's a draw with both choosing scissors!");

                }
                else if (Userchoice == "paper" && ComputerChoice == 2)
                {
                    Console.WriteLine($"{Computername} loses with rock against paper!");
                    UserWins++;
                }
                else if (Userchoice == "rock" && ComputerChoice == 2)
                {
                    Console.WriteLine($"It's a draw with both choosing rock!");

                }
                else if (Userchoice == "scissors" && ComputerChoice == 2)
                {
                    Console.WriteLine($"{Computername} wins with rock against scissors!");
                    Computerwins++;
                }
                else if (Userchoice == "paper" && ComputerChoice == 1)
                {
                    Console.WriteLine($"It's a draw with both choosing paper!");

                }
                else if (Userchoice == "rock" && ComputerChoice == 1)
                {
                    Console.WriteLine($"{Computername} wins with paper against rock!");
                    Computerwins++;
                }
                else
                {
                    Console.WriteLine($"{Computername} loses with paper against scissors!");
                    UserWins++;
                }
                
                i++;

            }
            if (Computerwins < UserWins)
            {
                Console.WriteLine($"{Computername} loses {Computerwins} to {UserWins}!");
            }
            else if (Computerwins > UserWins)
            {
                Console.WriteLine($"{Computername} wins {Computerwins} to {UserWins}!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            Console.ReadLine();
        }
    }
}
