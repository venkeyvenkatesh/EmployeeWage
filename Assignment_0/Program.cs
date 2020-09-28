using System;
//using System.Security.Cryptography.X509Certificates;

namespace Assignment_0
{


    public class Program
    {



        static void Main(string[] args)
        {

            EmpWageBuilderObject myobject = new EmpWageBuilderObject();
            myobject.addCompanyEmpWage("CAPGEMINI", 20, 4, 30);
            myobject.addCompanyEmpWage("Wipro", 10, 4, 20);


            myobject.computeEmpWage();




        }




    }
}
    

