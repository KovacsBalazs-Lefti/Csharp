using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP___dolgozat
{
    internal class Clock
    {
        public int Hour{get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string TimeZone {  get; set; }
        public bool Is24HourFormat { get; set; }

        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            SetTime(hour, minute, second);
            Hour = hour;
            Minute = minute;
            Second = second;
            TimeZone = timeZone;
            Is24HourFormat = is24HourFormat;

        }
        public void SetTime(int hour, int minute, int second)
        {
            if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
             {
                Hour = hour;
                Minute = minute;
                Second = second;
             }
            else 
            {
                throw new ArgumentException("Az időbeállítás érvénytelen");
            }
        }
        public void DisplayTime()
        {
            string timeFormat = Is24HourFormat ? "HH:mm:ss" : "hh:mm:ss tt"; 
            DateTime currenTime = DateTime.Now;
            
            if(!string.IsNullOrEmpty(TimeZone) )
            {
                try
                {
                  TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(TimeZone);
                }
                catch(TimeZoneNotFoundException)
                {
                    Console.WriteLine("Érvénytelen időzona");
                }
            }
            string formattedTime = currenTime.ToString(timeFormat);
            Console.WriteLine($"Az aktuális idő: {formattedTime} Időzona: {TimeZone})");
        }
        public void SetTimeZone(string timeZone)
        {
            this.TimeZone = timeZone;
        }
        public void ToggleTimeFormat()
        {
            Is24HourFormat = !Is24HourFormat; 
        }
        public void IncrementHour()
        {
            Hour = (Hour + 1) % 24;
        }
    }
}
