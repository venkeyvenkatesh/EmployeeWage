using System;
//using System.Security.Cryptography.X509Certificates;

namespace Assignment_0
{


    class Program
    {



        static void Main(string[] args)
        {

            EmpWageBuilderObject Capgemini = new EmpWageBuilderObject("CAPGEMINI", 20, 3, 25);
            EmpWageBuilderObject Wipro = new EmpWageBuilderObject("WIPRO", 15, 4, 30);

            Capgemini.computeWage();
            Wipro.computeWage();





        }




    }
}
    

