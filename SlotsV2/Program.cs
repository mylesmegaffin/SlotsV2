using System;
using System.Threading;

namespace Slots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = 100;
            decimal bet = 1;
            while (money != 0)
            {
                Console.WriteLine($"Balance: ${money}");
                Console.WriteLine("(Jackpot is all 5's) Hit Enter to play:");
                Console.ReadLine();
                money += Slot(bet);

                if (money == 0)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("So Close!!!!");
                    Console.WriteLine("Hit Enter to Deposit another 100");
                    Console.ReadLine();
                    money = 100;
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");

                }
            }
        }

        public static decimal Slot(decimal bet)
        {
            Random random = new Random();

            int wheel1 = random.Next(1, 7);
            int wheel2 = random.Next(1, 7);
            int wheel3 = random.Next(1, 7);
            decimal win;

            /* Jackpot Hard Code
            wheel1 = 7;
            wheel2 = 7;
            wheel3 = 7;
            */

            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine($"| {wheel1} | {wheel2} | {wheel3} |");
            Console.WriteLine("-------------");


            if (wheel1 == wheel2 && wheel2 == wheel3)
            {
                if (wheel1 == 5)
                {
                    win = bet * 100;
                    Console.WriteLine($"Jackpot: ${win}");
                    JackpotSong();
                }
                else
                {
                    win = bet * 10;
                    Console.WriteLine($"Winner: ${win}");
                    Song();
                }


                return win;
            }
            return -bet;
        }

        public static void Song()
        {
            Console.Beep(300, 100);
            Console.Beep(700, 100);
            Console.Beep(300, 100);
            Console.Beep(700, 100);
            Console.Beep(300, 100);
            Console.Beep(700, 100);
            Console.Beep(200, 100);
        }

        public static void JackpotSong()
        {
            Console.Beep(700, 100);
            Console.Beep(1200, 100);
            Console.Beep(900, 100);
            Console.Beep(1400, 100);
            Console.Beep(1100, 100);
            Console.Beep(1600, 100);
            Console.Beep(500, 100);
        }
    }
}
