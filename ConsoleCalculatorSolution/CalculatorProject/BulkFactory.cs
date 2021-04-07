using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;

namespace CalculatorProject
{
    class Bulkfactory : IAbstractBulkCalculator
    {
        public static BulkCalculation Create(List<double> listOfValues, Func<List<double>, double> op)
        {
            return new BulkCalculation(listOfValues, op);
        }
        BulkCalculation IAbstractBulkCalculator.Create(List<double> listOfValues, Func<List<double>, double> op)
        {
            return Bulkfactory.Create(listOfValues, op);
        }
    }
}
