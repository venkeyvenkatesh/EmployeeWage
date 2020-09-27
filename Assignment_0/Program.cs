using System;

namespace Assignment_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //variables

            int empWage = 0;
            int empHours = 0;

            int empCheck = rand.Next(0, 2);

            if (IS_FULL_TIME == empCheck)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }

            empWage = empHours * EMP_RATE_PER_HOUR;

            Console.Out.WriteLine("Wage is : " + empWage);
        }
    }
}
