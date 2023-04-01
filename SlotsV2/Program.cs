using SlotsV2;
using System;
using System.Threading;

namespace Slots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slot slot = new Slot(100);
            decimal money = 100;
            decimal bet = 1;


            while (money != 0)
            {
                Console.WriteLine($"Balance: ${money}");
                Console.WriteLine($"(Jackpot: {slot.Jackpot} is all 7's) Hit Enter to play:");
                Console.ReadLine();
                money += slot.Spin(bet);

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
    }
}
