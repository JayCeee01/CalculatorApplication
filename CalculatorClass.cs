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
        public delegate X Formula<X>(X num1, X num2);
        public Formula<double> formula;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        public event Formula<double> CalculateEvent
        {
            add { Console.WriteLine("Added the delegate: " + value); }
            remove { Console.WriteLine("Removed the delegate: " + value); }
        }
    }
}
