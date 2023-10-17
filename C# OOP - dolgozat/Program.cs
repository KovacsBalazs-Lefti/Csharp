using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP___dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock(12, 30, 45, "UTC+2", true);
            List<Alarm> alarms = new List<Alarm>
            {
                new Alarm(6, 0),
                new Alarm(8, 0)
            };
           
            Timer timer = new Timer(10);
            Console.WriteLine("Az aktuális idő:");
            myClock.DisplayTime();
            timer.StartTimer();
            Console.ReadLine();
        }
    }
}
