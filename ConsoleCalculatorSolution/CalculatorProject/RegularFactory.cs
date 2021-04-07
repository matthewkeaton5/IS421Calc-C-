using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;

namespace CalculatorProject
{
    class RegularFactory : IAbstractSingleCalculator
    {
        public static Calculation Create(double a, double b, Func<double, double, double> op)
        {
            return new Calculation(a, b, op);
        }
        Calculation IAbstractSingleCalculator.Create(double a, double b, Func<double, double, double> op)
        {
            return RegularFactory.Create(a, b, op);
        }
    }
}
