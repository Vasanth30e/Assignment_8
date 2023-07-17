using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    public class MonthSalary
    {
        public double SalaryCalc(double wHour, double nWdays, double projectHandles = 1, double extras = 0)
        {
            double monthlySalary = wHour * nWdays * 100 + projectHandles * 3000 + extras * 2000;
            return monthlySalary;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MonthSalary monthlySalary = new MonthSalary();

            string typeOfEmployee;
            Console.WriteLine("Enter employee type: \n HR for HR \n Admin for Admin \n SD for Software Developer");
            typeOfEmployee = (Console.ReadLine());

            int workingHour, noOfWorkingDAys, projectHandles, extras;
           
            switch (typeOfEmployee)
            {
                case "HR":
                    Console.WriteLine("Enter no. of Working Hour");
                    workingHour = int.Parse(Console.ReadLine());    

                    Console.WriteLine("Enter no. of Working Days");
                    noOfWorkingDAys = int.Parse(Console.ReadLine());
                  

                    Console.WriteLine("Monthly Salary for HR is " + monthlySalary.SalaryCalc(workingHour, noOfWorkingDAys));
                    break;

                case "Admin":
                    Console.WriteLine("Enter no. of Working Hour for Admin ");
                    workingHour = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter no. of Working Days for Admin");
                    noOfWorkingDAys = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter no. of Project Handles");
                    projectHandles = int.Parse(Console.ReadLine());


                    Console.WriteLine("Monthly Salary for Admin is " + monthlySalary.SalaryCalc( workingHour, noOfWorkingDAys, projectHandles));
                    break;


                case "SD":

                    Console.WriteLine("Enter no. of Working Hour");
                    workingHour = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter no. of Working Days");
                    noOfWorkingDAys = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter no. of Project Handles");
                    projectHandles = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter no. of Extras");
                    extras = int.Parse(Console.ReadLine());

                    Console.WriteLine("Monthly Salary for Software Developer is " + monthlySalary.SalaryCalc(workingHour, noOfWorkingDAys, projectHandles, extras));
                    break;
                
                default:
                    Console.WriteLine("Employee Type Not Exist");
                    break;

            }
            Console.ReadKey();

        }
    }
}
