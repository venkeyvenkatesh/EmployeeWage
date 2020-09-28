using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_0
{
    public class CompanyEmpWage
    {
         public string company;
         public int empWagePerHour;
         public int noOfWorkingDays;
         public int maxHoursPerMonth;
         public int totalEmpWage;

        public CompanyEmpWage(string company, int empWagePerHour, int noOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp wage for the company " + this.company + " is " + this.totalEmpWage;
        }

    }
}
