using System;
using System.Windows.Forms;

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

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MINHOURS = 0m;
        const decimal MAXHOURS = 84.0m;
        const decimal MINHRATE = 0m;
        const decimal MAXHRATE = 99.99m;
        const decimal MAXNONOT = 40.00m;
        const decimal OTRATE = 1.5m;
        const string ERRMSG = "Error In Input. Please Try Again.";

        //  Declare and initialize global variables
        static string first = "";
        static string last = "";
        static decimal hours = 0m;
        static decimal rate = 0m;
        static decimal gross = 0m;
        static decimal totalGross = 0m;
        static decimal avgGross = 0m;
        static int totalEmps = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateGrossPay();
        }

        private void CalculateGrossPay()
        {
            bool keepGoing = ValidateFirstName();

            if (keepGoing)
            {   //  ValidateFirstName returned true
                keepGoing = ValidateLastName();
            }
            else
            {   //  ValidateFirstName returned false
                return;
            }

            if (keepGoing)
            {   //  ValidateLastName returned true
                keepGoing = ValidateHours();
            }
            else
            {   //  ValidateLastName returned true
                return;
            }

            if (keepGoing)
            {   //  ValidateHours returned true
                keepGoing = ValidateRate();
            }
            else
            {   //  ValidateHours returned false
                return;
            }

            if (keepGoing)
            {   //  ValidateRate returned true
                CalculateGross();
                CalculateTotalStats();
            }
            else
            {   //  ValidateRate returned false
                return;
            }
        }

        private bool ValidateFirstName()
        {
            bool retVal = true;

            if (txtFirstName.Text.Trim() == "")
            {
                ShowErrorMessage("First Name Cannot Be Blank",
                                 "INVALID FIRST NAME INPUTTED");
                txtFirstName.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateLastName()
        {
            bool retVal = true;

            if (txtLastName.Text.Trim() == "")
            {
                ShowErrorMessage("Last Name Cannot Be Blank",
                                 "INVALID LAST NAME INPUTTED");
                txtLastName.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateHours()
        {
            bool retVal = true;
            bool result;

            result = decimal.TryParse(txtHours.Text, out hours);

            if (!result || hours < MINHOURS || hours > MAXHOURS)
            {
                ShowErrorMessage("Empty or out-of-range hours",
                                 "INVALID HOURS INPUTTED");
                txtHours.Text = "";
                txtHours.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateRate()
        {
            bool retVal = true;
            bool result;

            result = decimal.TryParse(txtRate.Text, out rate);

            if (!result || rate < MINHRATE || rate > MAXHRATE)
            {
                ShowErrorMessage("Empty or out-of-range rate",
                                 "INVALID RATE INPUTTED");
                txtRate.Text = "";
                txtRate.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void CalculateGross()
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

            //txtGross.Text = gross.ToString("c");
            txtGross.Text = $"{gross:c}";
        }

        private void CalculateTotalStats()
        {
            totalEmps = totalEmps + 1;
            totalGross = totalGross + gross;
            avgGross = totalGross / totalEmps;

            txtTotalEmps.Text = $"{totalEmps}";
            txtTotalGross.Text = $"{totalGross:c}";
            txtAverageGross.Text = $"{avgGross:c}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text  = "";
            txtHours.Text     = "";
            txtRate.Text      = "";
            txtGross.Text     = "";
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                    "Do You Really Want To Exit The Program?",
                    "EXIT NOW?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
        }

        private void ShowInfoMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
