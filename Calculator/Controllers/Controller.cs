using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Models;



namespace Calculator.Controlers
{
    public class Controller
    {

        Operations op = new Operations();

        public Double Multiply(double a,double b) {

          
            return op.Multiply(a,b);

        }

        public Double Divide(double a, double b)
        {

            return op.Divide(a, b);

        }

        public Double Substraction(double a, double b)
        {

            return op.Substraction(a, b);
        }

        public Double Add(double a, double b)
        {

            return op.Add(a, b);
        }

    }
}
