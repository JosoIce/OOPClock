using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOPClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            while (true)
            {
                clock.Tick();
                Console.WriteLine(clock.OutputTime);
                Thread.Sleep(1000); // Waits 1 second
            }
        }
    }
}
