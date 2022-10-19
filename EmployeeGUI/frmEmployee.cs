using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeGUI
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        //  Global constants
        const decimal MINHOURS =  0.00M;
        const decimal MAXHOURS = 84.00M;
        const decimal MINHRATE =  0.00M;
        const decimal MAXHRATE = 99.99M;

        //  Global variables
        static int totalEmps     =       0;
        static decimal lowGross  = 1000000.00M;
        static decimal highGross =      -1.00M;
        static decimal avgGross  =       0.00M;
        static decimal totGross  =       0.00M;

        private Employee employee = null;
        List<Employee> employees  = new List<Employee>();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0.00M;

            //  If all validity checks pass, create new Employee object
            if (IsValidData())
            {
                employee = new Employee(txtFirstName.Text,
                                        txtLastName.Text,
                                        Convert.ToDecimal(txtHoursWorked.Text),
                                        Convert.ToDecimal(txtHourlyRate.Text));

                grossPay = employee.CalculateGrossPay();

                txtGrossPay.Text = grossPay.ToString("c");

                totGross += grossPay;
                txtTotalGrossPay.Text = totGross.ToString("c");

                configureStats(grossPay);

                employees.Add(employee);

                printEmployeeStats();
            }
        }

        private bool IsValidData()
        {
            bool success        = true;
            string errorMessage = "";

            //  Validate presence of firstName field
            errorMessage += Validator.IsPresent(txtFirstName.Text, txtFirstName.Tag.ToString());

            //  Validate presence of lastName field
            errorMessage += Validator.IsPresent(txtLastName.Text, txtLastName.Tag.ToString());

            //  Validate hoursWorked field is decimal
            errorMessage += Validator.IsDecimal(txtHoursWorked.Text, txtHoursWorked.Tag.ToString());

            //  Validate hourlyRate field is decimal
            errorMessage += Validator.IsDecimal(txtHourlyRate.Text, txtHourlyRate.Tag.ToString());

            //  Validate hoursWorked field Is In Range
            errorMessage += Validator.IsWithinRange(txtHoursWorked.Text, 
                                                txtHoursWorked.Tag.ToString(),
                                                MINHOURS, MAXHOURS);

            //  Validate hourlyRate field Is In Range
            errorMessage += Validator.IsWithinRange(txtHourlyRate.Text,
                                                txtHourlyRate.Tag.ToString(),
                                                MINHRATE, MAXHRATE);

            if (errorMessage.Trim() != "")
            {
                MessageBox.Show(errorMessage, "INTPUT ERROR(S)");
                success = false;
            }

            return success;
        }

        private void configureStats(decimal grossPay)
        {
            totalEmps++;
            txtTotalEmployees.Text = totalEmps.ToString();

            calculateLowGross(grossPay);
            calculateHighGross(grossPay);
            calculateAvgGross();
        }

        private void calculateLowGross(decimal gross)
        {
            if (gross < lowGross)
            {
                lowGross = gross;
                txtLowGrossPay.Text = lowGross.ToString("c");
            }
        }

        private void calculateHighGross(decimal gross)
        {
            if (gross > highGross)
            {
                highGross = gross;
                txtHighGrossPay.Text = highGross.ToString("c");
            }
        }

        private void calculateAvgGross()
        {
            avgGross = totGross / totalEmps;
            txtAvgGrossPay.Text = avgGross.ToString("c");
        }

        private void printEmployeeStats()
        {
            string outputStr = "Currently Added Employee\n\n";

            outputStr += "First Name:\t" + employee.GetFirstName() + "\n";
            outputStr += "Last  Name:\t" + employee.GetLastName() + "\n";
            outputStr += "Hrs Worked:\t" + employee.GetHoursWorked() + "\n";
            outputStr += "Hrly  Rate:\t" + employee.GetHourlyRate() + "\n";
            outputStr += "Gross  Pay:\t" + employee.CalculateGrossPay().ToString("c");

            MessageBox.Show(outputStr, "FINAL LIST STATS",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        private void clearAndSetFocus()
        {
            txtFirstName.Text   = "";
            txtLastName.Text    = "";
            txtHoursWorked.Text = "";
            txtHourlyRate.Text  = "";
            txtGrossPay.Text    = "";
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void exitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
