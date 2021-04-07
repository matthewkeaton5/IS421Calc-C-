using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Interfaces;
using CalculatorProject.Events;

namespace CalculatorProject.Models
{
    public class Calculation : ICalculation
    {



        //store 1 value
        public double A { get; set; }
        //store 1 value
        public double B { get; set; }
        //store a single operation function
        public Func<double,double,double> Op { get; set; }



        //constructor for 3 param (Double, Double, Function)
        public Calculation(double a, double b, Func<double,double,double> calculation)
        {
            A = a;
            B = b;
            //this stores the operation to be performed on A and B
            Op = calculation;
        }

        public static Publisher _processEvent = new Publisher();

        public static Calculation Create(double a, double b, Func<double, double, double> op) //Static factory Create method creates the object for easy instatiation
        {
            var _calculation = IAbstractFactory.CalcSingle() ;
            return _calculation.Create(a,b,op);
        }
        //constructor with 0 param

        public Calculation() { }


        //This calls whatever operation was stored i.e. mult, div, add, sub and returns the answer
        public double GetResult()
        {
            return Op(A, B);

        }
    }
}
