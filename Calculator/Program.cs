using System;
using Calculator.Controlers;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
               double _result,_input1=0,_input2=0;

               Controller calc = new Controller();

            try { 
            
                Console.Write("Introduce el primer número: ");
                _input1 = double.Parse(Console.ReadLine());
                
                Console.Write("Introduce el segundo número: ");
                _input2 = double.Parse(Console.ReadLine());
            
                _result = calc.Divide(_input1, _input2);
                Console.WriteLine("El resultado de la operación es: " + _result);
            } catch
            {
                
                Console.WriteLine("Solo se aceptan valores numéricos");
                _result = double.NaN;
            }

            
        }
    }
}
