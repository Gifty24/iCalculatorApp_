using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCalculatorApp_
{
    public class Math:ICalculator
    {
        private double result;
        public double Add(double a, double b)
        {
            result=a+b;
            return result;
        }
        public double Subtract(double a, double b)
        {
            result=a-b; 
            return result;
        }
        public double Multiply(double a, double b)
        {
            result=a*b;
            return result;
        }
        public double Divide(double a, double b)
        { 
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            result=a/b;
            return result;
        }
        public double SquareRoot(double a)
        {
            if (a<0)
            {
                throw new ArithmeticException("Cannot calculate the square root of a negative number");
                
            }
            result = System.Math.Sqrt(a);
            return result;
            
        }
        public double Percentage(double a, double b)
        {
            result = (a * b) / 100;
            return result;
        }
        public void Clear()
        {
            result = 0;
        }

    }
}
