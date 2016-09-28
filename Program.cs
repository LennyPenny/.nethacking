using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crackme
{
    class Program
    {
        static void Main(string[] args)
        {
            var tries = 0;

            while (Console.ReadLine() != "kassel")
            {
                Console.WriteLine($"Wrong password, you tried {++tries} {(tries == 1 ? "time" : "times")}");
                Console.WriteLine("Try again");
            }

            Console.WriteLine("Success!");

            Console.ReadKey();
        }
    }
}
