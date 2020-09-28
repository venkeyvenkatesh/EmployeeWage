using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assignment_0
{
    public class EmpWageBuilderObject
    {
        //variable
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int noOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderObject()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company,int empRatePerHour,int noOfWorkingDays,int maxHoursPerMonth)
        {
            companyEmpWageArray[this.noOfCompany] = new CompanyEmpWage(company, empRatePerHour, noOfWorkingDays, maxHoursPerMonth);
            noOfCompany++;
        }
     public void computeEmpWage()
        {
            for(int i=0;i<noOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
    public int  computeEmpWage(CompanyEmpWage companyEmpWage)
    {
            int empHrs = 0;
        


        int numberOfHours = 0;
        int workingDays = 0;
      //  int total_wage = 0;

            while (numberOfHours <= companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.noOfWorkingDays)
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
         return numberOfHours * companyEmpWage.empWagePerHour;
        //Console.Out.WriteLine("Total Emp wage  for company : "+this.company+" is " + totalEmpWage);
      
    }

    //public string toString()
    //{
    //    return "Total emp age for company : "+ this.company + " is "+ this.totalEmpWage;
    //}
   
    }



    }

