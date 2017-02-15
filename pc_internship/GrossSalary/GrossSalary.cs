using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pc_internship.GrossSalary
{
    public static class GrossSalary //static class to call the method needed to calculate employees gross salary
    {
        public static string GetGrossSalary(double NetSalary)
        {
            return String.Format("{0:0.00}", (NetSalary * 100) / 76);
        }
    }
}