using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;
using CalculatorProject.Models;


namespace CalculatorProject
{
    public class Builder : ICalculator
    {
        private Calculations _Calculations = new Calculations();


        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {

            var _calculation = Calculation.Create(a, b, _operation);
            _Calculations.AddCalculation(_calculation);
            return _calculation;
        }

        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> _operation)
        {
            var _calculation = BulkCalculation.Create(listOfValues, _operation);
            _Calculations.AddCalculation(_calculation);
            return _calculation;
        }
        public List<ICalculation> GetList()
        {
            var listResult = _Calculations._Calculations;
            return listResult;
        }
    }
}
