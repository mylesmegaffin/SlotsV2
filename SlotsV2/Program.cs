using SlotsV2;
using System;
using System.Threading;

namespace Slots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        public static void Game()
        {
            decimal totalDeposited = 0;
            decimal totalWinnings = 0;
            Slot slot = new Slot(100);
            decimal money = 0;

            while (true)
            {
                Console.WriteLine($"Balance: ${money}");
                Console.WriteLine($"Jackpot: ${slot.Jackpot}");

                if (money <= 0)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"Total Winnings: {totalWinnings} | Total Deposits: {totalDeposited}");

                    Console.WriteLine("Enter the amount you'd like to deposit");
                    string userDeposit = Console.ReadLine();
                    Console.Clear();
                    if (decimal.TryParse(userDeposit, out decimal depositAmount) && depositAmount > 0)
                    {
                        money += depositAmount;
                        totalDeposited = depositAmount;
                    }
                    else
                    {
                        Console.WriteLine("Error Incorrect Deposit Amount");
                        Console.WriteLine("--------------------------------------------------");
                    }

                }
                else
                {
                    Console.WriteLine($"Jackpot is all 7's \nEnter Bet Amount:");
                    string userInput = Console.ReadLine();
                    if (decimal.TryParse(userInput, out decimal betAmount) && betAmount > 0 && betAmount <= money)
                    {
                        Console.Clear();
                        decimal winnings = slot.Spin(betAmount);
                        money += winnings;
                        if (winnings > 0)
                        {
                            totalWinnings += winnings;
                        }
                        Console.WriteLine($"Bet Amount: ${betAmount}");
                    }
                    else
                    {
                        Console.WriteLine("Error, Incorrect amount");
                    }
                }
            }
        }
    }
}
