using System;
//using System.Security.Cryptography.X509Certificates;

namespace Assignment_0
{


    public class Program
    {



        static void Main(string[] args)
        {

            EmpWage Capgemini = new EmpWage("CAPGEMINI", 20, 3, 25);
            EmpWage Wipro = new EmpWage("WIPRO", 15, 4, 30);

           int cap_salary= Capgemini.computeWage();
            int wipro_salary = Wipro.computeWage();

           



        }




    }
}
    

