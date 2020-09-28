using System;
//using System.Security.Cryptography.X509Certificates;

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

            Console.WriteLine("Total wage :" + MonthlyWage());

        }


        public static int EmpHours()
        {
            Random rand = new Random();
            int type = rand.Next(0, 3);
            int hours = 0;
            switch (type)
            {
                case IS_FULL_TIME:
                    hours = 8;
                    return hours;
                //break;
                case IS_PART_TIME:
                    hours = 4;
                    return hours;
                //   break;
                default:
                    hours = 0;
                    return hours;
                    // break;

            }
        }
                 public static  int MonthlyWage()
            { 
                 int numberOfHours = 0;
            // int workingDays = 0;
               int total_wage = 0;
                for (int workingDays = 1; workingDays <= TOTAL_WORKING_DAYS; workingDays++)
                {
                    numberOfHours = EmpHours();

                    //workingDays++;


                    Console.WriteLine("Day " + workingDays + " hours " + numberOfHours);
                    total_wage = total_wage + (numberOfHours) * WAGE_PER_HOUR;
                }
                    return total_wage;
                }

               

            }
           
        }
    

