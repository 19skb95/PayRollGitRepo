using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollLib
{
    public class CalculatePaySlip
    {
        //Checks the date less than Jan-01-2018
        public static bool CheckDate(string Date)
        {
            return (Convert.ToDateTime(Date).Year < 2018);
        }
        //Increaments The Salary
        public static double SalaryIncreament(string slary)
        {
            return (Convert.ToDouble(slary) * 1.1);
        }

    }
}
