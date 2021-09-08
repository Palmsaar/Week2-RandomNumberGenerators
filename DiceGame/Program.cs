using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int Player1 = rnd.Next(1, 7);

            Random rnd2 = new Random();

            int Player2 = rnd2.Next(1, 7);

            if (Player1 < Player2)
            {
                Console.WriteLine($"Player 2 won with {Player2} against Player 1s {Player1}!");
            }
            else if (Player2 < Player1)
            {
                Console.WriteLine($"Player 1 won with {Player1} against Player 2s {Player2}!");
            }
            else
            {
                Console.WriteLine($"Player 1 and Player 2 ended up both getting {Player2}!");
            }






        }
    }
}
