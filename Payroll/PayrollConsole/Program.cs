using System;
using static System.Console;

/*
 *		This is a C# Payroll Program
 *		
 *		Individual Inputs:
 *		------------------
 *		first name, last name, hours worked, hourly rate
 *
 *		All inputs are validated
 *
 *		Individual Outputs:
 *		-------------------
 *		first name, last name, hours worked, hourly rate
 *		gross pay
 *
 *		Overtime pay (if warranted) also calculated
 *
 *		Totals Output:
 *		--------------
 *		total number of employees
 *		total gross pay all employees
 *		average gross pay all employees
 */

namespace PayrollConsole
{
    internal class Program
    {
        //  Declare and initialize program constants
        const decimal MINHOURS =  0m;
        const decimal MAXHOURS = 84.0m;
        const decimal MINHRATE =  0m;
        const decimal MAXHRATE = 99.99m;
        const decimal MAXNONOT = 40.00m;
        const decimal OTRATE   =  1.5m;
        const string  ERRMSG   = "Error In Input. Please Try Again.";

        //  Declare and initialize global variables
        static string first         = "";
        static string last          = "";
        static decimal hours        = 0m;
        static decimal rate         = 0m;
        static decimal gross        = 0m;
        static decimal totalGross   = 0m;
        static decimal avgGross     = 0m;
        static int totalEmps        = 0;
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)       //  while (keepGoing == true)
            {
                Clear();
                InputFirstName();
                InputLastName();
                InputHours();
                InputRate();
                CalculateGrossPay();
                UpdateTotals();
                PrintIndStats();
                keepGoing = RunProgramAgain();
            }

            PrintFinalStats();
        }

        static void InputFirstName()
        {
            Write("\nPlease Input First Name:\t");
            first = ReadLine();

            //  Validate that first name is NOT empty
            if (first.Trim() == "")
            {
                WriteLine("\n\n" + ERRMSG);
                InputFirstName();
            }
        }

        static void InputLastName()
        {
            Write("\nPlease Input Last Name:\t");
            last = ReadLine();

            //  Validate that Last name is NOT empty
            if (last.Trim() == "")
            {
                WriteLine("\n\n" + ERRMSG);
                InputLastName();
            }
        }

        static void InputHours()
        {
            string hrsStr = "";
            bool result;

            Write($"\nEnter hours between {MINHOURS} and {MAXHOURS}\t\t");
            hrsStr = ReadLine();

            //  Attempt to convert hrsStr to a decimal
            result = decimal.TryParse(hrsStr, out hours);

            if (!result || hours < MINHOURS || hours > MAXHOURS)
            {
                WriteLine("\n\n" + ERRMSG);
                InputHours();
            }
        }

        static void InputRate()
        {
            string rateStr = "";
            bool result;

            Write($"\nEnter rate between {MINHRATE} and {MAXHRATE}\t\t");
            rateStr = ReadLine();

            //  Attempt to convert rateStr to a decimal
            result = decimal.TryParse(rateStr, out rate);

            if (!result || rate < MINHRATE || rate > MAXHRATE)
            {
                WriteLine("\n\n" + ERRMSG);
                InputRate();
            }
        }

        static void CalculateGrossPay()
        {
            //  Straight time check (hours <= 40)
            if (hours <= MAXNONOT)
            {
                gross = hours * rate;
            }
            else
            {   //  You worked some overtime
                gross = (MAXNONOT * rate) +     //  Straight time   
                        ((hours - MAXNONOT) * rate * OTRATE);
            }
        }

        static void UpdateTotals()
        {
            totalEmps  = totalEmps + 1;
            totalGross = totalGross + gross;
            avgGross   = totalGross / totalEmps;
        }

        static void PrintIndStats()
        {
            string outputStr = $"First Name\t\t\t{first}";
            outputStr += $"\nLast Name\t\t\t\t{last}";
            outputStr += $"\nHours Worked:\t\t{hours:n2}";
            outputStr += $"\nHourly Rate:\t\t{rate:c}";
            outputStr += $"\nGross Pay:\t\t{gross:c}";

            WriteLine("\n\nIndividual Employee Stats:\n");
            WriteLine($"{outputStr}");
            ReadLine();
        }

        static bool RunProgramAgain()
        {
            bool retVal = true;

            Write("Run Program Again? (Y / N):\t");
            string again = ReadLine().ToUpper();

            if (again.Trim() == "")
            {
                return false;
            }

            char firstCh = again[0];

            if (firstCh != 'Y')
            {
                retVal = false;
            }

            return retVal;
        }

        static void PrintFinalStats()
        {
            Clear();
            string outputStr = $"Total Employees:\t\t{totalEmps}";
            outputStr += $"\nTotal Gross Pay:\t\t{totalGross:c}";
            outputStr += $"\nAverage Gross:\t\t{avgGross:c}";

            WriteLine("Final Employee Stats:\n");
            WriteLine($"{outputStr}");
            ReadLine();
        }
    }
}
