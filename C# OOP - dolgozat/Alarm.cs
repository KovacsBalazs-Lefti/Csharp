using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP___dolgozat
{
    internal class Alarm
    {
        public int AlarmHour {  get; set; }
        public int AlarmMinute { get; set; }
        public bool IsAlarmOn { get; set; }

        public Alarm(int alarmHour, int alarmMinute)
        {
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            IsAlarmOn = true;
        }
        public void TurnOnAlarm()
        {
            IsAlarmOn = true;
            Console.WriteLine("Az ébresztő be van kapcsolva");
 
        }
        public void TurnOffAlarm()
        {
            IsAlarmOn = false;
            Console.WriteLine("Az ébresztő ki van kapcsolva");

        }
        public bool IsAlarmTime(int hour, int minute)
        {
            if(IsAlarmOn)
            {
                return AlarmHour == hour && AlarmMinute == minute;  

            }
            return false;
        }
        
    }
}
