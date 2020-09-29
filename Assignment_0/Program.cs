using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_0
{
   
    public class Program
    {

       static Dictionary<string, int> dictionary = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of companies");
            int n = Convert.ToInt32(Console.ReadLine());
            
            EmpWage[] obj = new EmpWage[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of the company");
                string company = Console.ReadLine();
                obj[i] = new EmpWage(company, 20, 3, 25);

              
                dictionary.Add(obj[i].GetCompany(), obj[i].computeWage());
                
               // getWageByCompany(obj[i].GetCompany());
            }

            foreach(KeyValuePair<string,int> kvp in dictionary)
            {
                Console.WriteLine("The wage of employee in " + kvp.Key + " is " + kvp.Value);
            }

        }

       
        }

        



    }

    

