using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace C__OOP___dolgozat
{
    internal class Timer
    {
        private int RemainingSeconds {  get; set; }
        private System.Timers.Timer timer;
        public Timer(int seconds) 
        {
            SetTime(seconds);
        }
        public void SetTime(int seconds)
        {
            if (seconds >= 0)
            {
                RemainingSeconds = seconds;
            }
            else
            {
                throw new ArgumentException("Az idő beállítás érvénytelen");
            }
        }
        public void StartTimer()
        {
            if(timer != null)
            {
                Console.WriteLine("Az időzítő már fut.");
                return;
            }
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            RemainingSeconds--;
            if (RemainingSeconds <= 0)
            {
                Console.WriteLine("Az idő lejárt.");
                StopTimer();
            }
            else
            {
                Console.WriteLine($"A hátralévő idő:{RemainingSeconds} másodperc");
            }
        }
        private void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
        }
    }
}
