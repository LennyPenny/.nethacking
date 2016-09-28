using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace crackme
{
    class Program
    {
        static void Main(string[] args)
        {
            var crackmeTask = CrackMe();
            while (!crackmeTask.IsCompleted)
            {
                Thread.Sleep(100);
            }
        }

        private static async Task CrackMe()
        {
            var tries = 0;

            while (Console.ReadLine() != "kassel")
            {
                Console.WriteLine($"Wrong password, you tried {++tries} {(tries == 1 ? "time" : "times")}");
                Console.WriteLine("Try again");

                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                });
            }

            Console.WriteLine("Success!");

            Console.ReadKey();
        }
    }
}
