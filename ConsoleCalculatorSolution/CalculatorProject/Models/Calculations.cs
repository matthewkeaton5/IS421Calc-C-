using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    class Calculations
    {
        public List<ICalculation> _Calculations = new List<ICalculation>();

        public void AddCalculation(ICalculation calculations)
        {
            this._Calculations.Add(calculations);
        }
    }
}
