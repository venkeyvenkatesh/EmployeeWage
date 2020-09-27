using System;

namespace Assignment_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int is_full_time = 1;
            int is_part_time = 2;
            int wage = 20;

            //variable
            int type = rand.Next(0, 3);
            int hours = 0;
            int total_wage = 0;

            if (is_full_time == type)
            {
                hours = 8;

            }
            else if (is_part_time == type)
            {
                hours = 4;
            }
            else
            {
                hours = 0;
            }


            total_wage = hours * wage;


            Console.Out.WriteLine(total_wage);
        }
    }
}
