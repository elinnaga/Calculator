using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public class Operations
    {
        public Operations()
        {

        }

        private double Result { get; set; }
        public Double Multiply(double a,double b)
        {
            Result = a * b;
            return Result;
        }

        public Double Divide(double a, double b)
        {
            if (b != 0)
            {

                Result = a / b;

            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
            }

            return Result;
        }

        public Double Substraction(double a,double b)
        {

            return a - b;
        }

        public Double Add(double a,double b)
        {

            return a + b;
        }
    }
}
