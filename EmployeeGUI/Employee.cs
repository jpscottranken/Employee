using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeGUI
{
    public class Employee
    {
        //  Program constants
        const decimal MAXSTRAIGHT  = 40.00M;
        const decimal OVERTIMERATE = 1.50M;

        //  Instance variables
        private string  _firstName;
        private string  _lastName;
        private decimal _hoursWorked;
        private decimal _hourlyRate;
        private decimal _grossPay;

        //  Constructor
        public Employee(string fn, string ln, decimal hw, decimal hr)
        {
            _firstName   = fn;
            _lastName    = ln;
            _hoursWorked = hw;
            _hourlyRate  = hr;
        }

        //  Getters
        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public decimal GetHoursWorked()
        {
            return _hoursWorked;
        }

        public decimal GetHourlyRate()
        {
            return _hourlyRate;
        }

        public decimal CalculateGrossPay()
        {
            if (_hoursWorked <= MAXSTRAIGHT)
            {   //  Employee worked <= 40 hours. No OT
                _grossPay = _hoursWorked * _hourlyRate;
            }
            else
            {   //  Emploee worked > 40 hours. Has OT coming.
                _grossPay = (MAXSTRAIGHT * _hourlyRate) +
                            ((_hoursWorked - MAXSTRAIGHT) *
                              _hourlyRate * OVERTIMERATE);
            }

            return _grossPay;
        }
    }
}
