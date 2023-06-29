using System;

namespace EmployeeGUI
{
    public class Employee
    {
        //  Program constants
        const decimal MAXSTRAIGHT  = 40.00M;
        const decimal OVERTIMERATE =  1.50M;

        private decimal _grossPay;

        //  Constructor
        public Employee(string fn, string ln, decimal hw, decimal hr)
        {
            FirstName   = fn;
            LastName    = ln;
            HoursWorked = hw;
            HourlyRate  = hr;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public decimal CalculateGrossPay()
        {
            if (HoursWorked <= MAXSTRAIGHT)
            {   //  Employee worked <= 40 hours. No OT
                _grossPay = HoursWorked * HourlyRate;
            }
            else
            {   //  Emploee worked > 40 hours. Has OT coming.
                _grossPay = (MAXSTRAIGHT * HourlyRate) +
                            ((HoursWorked - MAXSTRAIGHT) *
                              HourlyRate * OVERTIMERATE);
            }

            return _grossPay;
        }

        public override string ToString()
        {
            return "NAME: " + FirstName + " " + LastName + "\n" +
                  "HOURS: " + HoursWorked.ToString("n2") + "\n" +
                   "RATE: " + HourlyRate.ToString("c")   + "\n" +
                  "GROSS: " + _grossPay.ToString("c")    + "\n\n";
        }
    }
}
