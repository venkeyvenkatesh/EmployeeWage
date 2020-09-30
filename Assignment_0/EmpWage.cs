using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assignment_0
{
    class EmpWage :IcompanyWage
    {
        //variable
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empWagePerHour;
        private int noOfWorkingDays;
        private int maxHoursPerMonth;


        private Dictionary<int, int> dailyWage = new Dictionary<int, int>();
        public void displayDailyWage()
        {
            foreach (KeyValuePair<int, int> kvp in this.dailyWage)
            {
                Console.WriteLine("Day  " + kvp.Key + " wage  is " + kvp.Value);
            }
        }

        public EmpWage(string company,  int empWagePerHour,  int noOfWorkingDays,  int maxHoursPerMonth )
            {
            this.company=company;
            this. empWagePerHour=empWagePerHour;
            this.noOfWorkingDays=noOfWorkingDays;
            this.maxHoursPerMonth=maxHoursPerMonth;
            }

      
        public String GetCompany()
        {
            return this.company;
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
               
                case IS_PART_TIME:
                    hours = 4;
                    return hours;
                
                default:
                    hours = 0;
                    return hours;
                    

            }
        }
            public int computeWage()
         {

            int days = 1;
            int totalEmpWage = 0;
            int hour = 0;
            int numberOfHours = 0;
             int workingDays = 0;
     

            while (numberOfHours <= this.maxHoursPerMonth && workingDays < this.noOfWorkingDays)
            {
                hour = EmpHours();
            workingDays++;
               this.dailyWage.Add(days, hour*this.empWagePerHour);
                days++;
            numberOfHours += hour;
           // Console.WriteLine("Days " + workingDays + " Emp hrs " + empHrs);

            }

        totalEmpWage = numberOfHours * this.empWagePerHour;
    
               return totalEmpWage;
      
    }

  
   
    }



    }

