using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using CalculatorProject.Events;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {

        public Builder _Builder = new Builder();
        public Publisher _publisher = new Publisher();

        private ICalculator _calculator;
        public Calculator() { }

        public Calculator(ICalculator calculator)
        {
            this._calculator = calculator;

        }
        
        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            var _calculation = _calculator.CreateCalculation(a, b, _operation);
            _publisher.setCalculation(_calculation);
            return _calculator.CreateCalculation(a, b, _operation);


        }
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation)
        {

            return _calculator.CreateCalculation(listOfValues, operation);

        }
    }
}
