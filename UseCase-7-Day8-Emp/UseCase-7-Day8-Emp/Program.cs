using System;

namespace UseCase_7_Employee_Wage
{
    public class EmployeeWage
    {
        //Constants
        public const int is_Part_Time = 1;
        public const int is_Full_Time = 2;
        public const int Emp_Rate_Per_Hr = 20;
    }
    public class Program
    {
        public const int emp_Rate_Per_Hr = 20;
        static void Main(string[] args)
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case 1:
                    empHrs = 4;
                    break;
                case 2:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine("Employee Wage =" + empWage);
        }
    }
}
