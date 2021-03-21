using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{
    interface IBulkCalculation
    {
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation);
    }
}
