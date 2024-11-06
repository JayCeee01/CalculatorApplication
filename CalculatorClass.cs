using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorApplication.CalculatorClass;

namespace CalculatorApplication
{
    internal class CalculatorClass
    {
        public delegate X Formula<X>(X arg);
        public Formula<double> formula;

        public double GetSum(double num)
        {
            return num;
        }

        public double GetDifference(double num)
        {
            return num;
        }

        public double GetProduct(double num)
        {
            return num;
        }

        public double GetQuotient(double num)
        {
            return num;
        }

        public event Formula<double> CalculateEvent
        {
            add { Console.WriteLine("Added the delegate: " + value); }
            remove { Console.WriteLine("Removed the delegate: " + value); }
        }
    }
}
