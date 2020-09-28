using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assignment_0
{
    class EmpWageBuilderObject
    {
        //variable
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empWagePerHour;
        private int noOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company,  int empWagePerHour,  int noOfWorkingDays,  int maxHoursPerMonth )
            {
            this.company=company;
            this. empWagePerHour=empWagePerHour;
            this.noOfWorkingDays=noOfWorkingDays;
            this.maxHoursPerMonth=maxHoursPerMonth;
            }

    public void computeWage()
    {
        int empHrs = 0, totalEmpWage = 0;
        


        int numberOfHours = 0;
        int workingDays = 0;
      //  int total_wage = 0;

            while (numberOfHours <= this.maxHoursPerMonth && workingDays < this.noOfWorkingDays)
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
            workingDays++;
            //empWage = empHrs * EMP_RATE_PER_HOUR;
            // totalEmpWage = totalEmpWage + empWage;
            numberOfHours += empHrs;
            Console.WriteLine("Days " + workingDays + " Emp hrs " + empHrs);

            }

        totalEmpWage = numberOfHours * this.empWagePerHour;
        Console.Out.WriteLine("Total Emp wage  for company : "+this.company+" is " + totalEmpWage);
      
    }

    public string toString()
    {
        return "Total emp age for company : "+ this.company + " is "+ this.totalEmpWage;
    }
   
    }



    }

