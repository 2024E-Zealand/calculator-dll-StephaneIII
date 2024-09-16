using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class Operations
    {
        public Operations()
        {
            
        }
        /// <summary>
        /// This method can add to numbers
        /// </summary>
        /// <param name="a"> a is a number</param>
        /// <param name="b">b is also a number</param>
        /// <returns>this method will return result of the addition</returns>

        public double Add(double a, double b)
        {
            return a +b;
        }

        /// <summary>
        /// This method can substract to numbers
        /// </summary>
        /// <param name="a"> a is a number</param>
        /// <param name="b">b is also a number</param>
        /// <returns>this method will return result of the substraction</returns>

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// This method can multiply to numbers
        /// </summary>
        /// <param name="a"> a is a number</param>
        /// <param name="b">b is also a number</param>
        /// <returns>this method will return result of the multiplication</returns>

        public double Multiply(double a, double b)
        {
            return b * a;
        }

        /// <summary>
        /// This method can divide to numbers
        /// </summary>
        /// <param name="a"> a is a number</param>
        /// <param name="b">b is also a number</param>
        /// <returns>this method will return result of the division</returns>

        public double divide(double a, double b)
        {
            return a / b;
        }



    }
}
