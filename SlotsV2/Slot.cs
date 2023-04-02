using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotsV2
{
    internal class Slot
    {
        public decimal Jackpot { get; set; }

        public decimal Win { get; set; }


        string[] wheel = new string[]
        {
            "!",
            "=",
            "$",
            "*",
            "9",
            "7"
        };

        public Slot() { }

        public Slot(decimal Jackpot)
        {
            this.Jackpot = Jackpot;
        }

        public decimal Spin(decimal bet)
        {
            Random random = new Random();

            string wheel1 = wheel.ElementAt(random.Next(0, 6));
            string wheel2 = wheel.ElementAt(random.Next(0, 6));
            string wheel3 = wheel.ElementAt(random.Next(0, 6));

            Jackpot += bet/4;
            Console.WriteLine("-------------");
            Console.WriteLine($"| {wheel1} | {wheel2} | {wheel3} |");
            Console.WriteLine("-------------");


            if (wheel1.Equals(wheel2) && wheel2.Equals(wheel3))
            {
                if (wheel1.Equals("7"))
                {
                    Win = bet + Jackpot;
                    Jackpot = 100;
                    Console.WriteLine($"Jackpot: ${Win}");
                }
                else
                {
                    Win = bet * 10;
                    Console.WriteLine($"Winner: ${Win}");
                }


                return Win;
            }
            return -bet;

        }
    }
}
