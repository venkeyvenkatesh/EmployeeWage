using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assignment_0
{
    class EmpWage
    {
        //variable
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empWagePerHour;
        private int noOfWorkingDays;
        private int maxHoursPerMonth;
       

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

          
            int totalEmpWage = 0;

            int numberOfHours = 0;
             int workingDays = 0;
     

            while (numberOfHours <= this.maxHoursPerMonth && workingDays < this.noOfWorkingDays)
            {

            workingDays++;
            
            numberOfHours += EmpHours();
           // Console.WriteLine("Days " + workingDays + " Emp hrs " + empHrs);

            }

        totalEmpWage = numberOfHours * this.empWagePerHour;
    
               return totalEmpWage;
      
    }

  
   
    }



    }

