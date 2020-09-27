using System;

namespace Assignment_0
{
    
    
    class Program
    {

        // contants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;

        static void Main(string[] args)
        {
            //variable
            
            int empHrs = 0,empWage = 0, totalEmpWage = 0;

            for(int day=1;day<=NUM_OF_WORKING_DAYS;day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                       empHrs = 4;
                        break;
                    default:
                       empHrs = 0;
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage = totalEmpWage + empWage;

                Console.WriteLine("Emp Wage for day "+ day +" is :" + empWage);

            }
           

            Console.Out.WriteLine("Total Emp wage : "+totalEmpWage);
        }
    }
}
