using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_0
{
    public interface IcompanyWage
    {
        public void displayDailyWage();
        public int computeWage();

    }

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
                obj[i].displayDailyWage();
                getWageByCompany(obj[i].GetCompany());
            }
        }

            public static void getWageByCompany(string company)
            {

                foreach (KeyValuePair<string, int> kvp in dictionary)
                {
                    if (string.Compare(company, kvp.Key) == 0)
                    {
                        Console.WriteLine("The total wage in " + company + " is : " + kvp.Value);
                        break;
                    }
                }

            }

       
        }

        



    }

    

