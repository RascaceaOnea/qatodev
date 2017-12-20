using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngleProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = "12:01";
            int degrees = 360;

            //int minutesString = Convert.ToInt32(time.Substring(time.Length - 2));
            string[] timeHourAndMinutes = time.Split(':');

            int hour = Convert.ToInt32(timeHourAndMinutes[0]);
            int minutes = Convert.ToInt32(timeHourAndMinutes[1]);

            hour = hour % 12;


            double minuteAngle = ((float)minutes / 60) * degrees;

            double hourAngle = (((float)hour / 12) + (((float)minutes / 60) / 12)) * degrees;

            double angle = hourAngle - minuteAngle;

            if (angle < 0) angle = angle * -1;

            Console.Write("{0:N2}", angle);
            Console.ReadLine();

        }
    }
}
