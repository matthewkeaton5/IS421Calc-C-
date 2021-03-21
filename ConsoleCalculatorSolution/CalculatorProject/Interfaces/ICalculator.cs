﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Interfaces
{
    public interface ICalculator
    {
        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation);
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation);
    }
}
