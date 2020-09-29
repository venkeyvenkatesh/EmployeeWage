using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_0
{


    public class Program
    {



        static void Main(string[] args)
        {
            int n = 2;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            EmpWage[] obj = new EmpWage[n];

            for (int i = 0; i < n; i++)
            {
                string company = Console.ReadLine();
                obj[i] = new EmpWage(company, 20, 3, 25);
                

                dictionary.Add(obj[i].GetCompany(), obj[i].computeWage());
            }

               




               


            foreach(KeyValuePair<string,int> kvp in dictionary)
            {
                Console.WriteLine("Wage of employee in " + kvp.Key + " is " + kvp.Value);
            }
        }




    }
}
    

