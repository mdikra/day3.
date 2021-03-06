using System;

namespace wagesforMonth
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0; int empwage = 0;
            int totalEmpWage = 0;
            //computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empwage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empwage;
                Console.WriteLine("Emp Wage : " + empwage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}