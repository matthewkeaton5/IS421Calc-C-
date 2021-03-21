using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {

        public Builder _Builder = new Builder();

        private ICalculator _calculator;
        public Calculator() { }

        public Calculator(ICalculator calculator)
        {
            this._calculator = calculator;

        }
        
        public ICalculation RegularCalculator(double a, double b, Func<double, double, double> _operation)
        {

            return _calculator.CreateCalculation(a, b, _operation);

        }
        public ICalculation BulkCalculator(List<double> listOfValues, Func<List<double>, double> operation)
        {

            return _calculator.CreateCalculation(listOfValues, operation);

        }
    }
}
