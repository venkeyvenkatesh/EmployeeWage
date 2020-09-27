using System;

namespace Assignment_0
{


    class Program
    {
        //variable
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int TOTAL_WORKING_HOURS = 100;
        public const int TOTAL_WORKING_DAYS = 20;
        public const int WAGE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            Random rand = new Random();



            int numberOfHours = 0;
            int workingDays = 0;
            int total_wage = 0;


            while (numberOfHours <= TOTAL_WORKING_HOURS && workingDays <= TOTAL_WORKING_DAYS)
            {
                int type = rand.Next(0, 3);
                int hours = 0;
                switch (type)
                {
                    case IS_FULL_TIME:
                        hours = 8;
                        break;
                    case IS_PART_TIME:
                        hours = 4;
                        break;
                    default:
                        hours = 0;
                        break;

                }

                numberOfHours += hours;

                workingDays++;


                Console.Out.WriteLine("Day " + workingDays + " hours " + hours);
                total_wage = total_wage + (hours) * WAGE_PER_HOUR;

            }
            Console.WriteLine("Total wage :" + total_wage);
        }
    }
}
