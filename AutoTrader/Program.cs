using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoTrader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Made by TypicalIllusion#9034";
            Console.WriteLine("How long do you want to wait (type in SECONDS)? (made for 2 minute slowmode and auto adds 10 seconds)");
            var duration = int.Parse(Console.ReadLine());
            duration *= 1000;
            Console.WriteLine(duration / 1000 + " second(s)?");
            Console.WriteLine("Press enter to confirm");
            while (Console.ReadKey().Key != ConsoleKey.Enter);
            Console.WriteLine("Starting in 10 seconds");
            Thread.Sleep(10000);
            for (int i = 0; i < 1; i--)
            {
                SendKeys.SendWait("^" + "v");
                SendKeys.SendWait("{ENTER}");
                Console.WriteLine("Messages sent: " + i);
                Thread.Sleep(duration / 2 + 10000);
                Console.WriteLine("halfway there, " + (duration / 2 + 10000) / 1000 + " seconds until message sends");
                Thread.Sleep(duration / 2 + 10000);
            }
        }
    }
}
