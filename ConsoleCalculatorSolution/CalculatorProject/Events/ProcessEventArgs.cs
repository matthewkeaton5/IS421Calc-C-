using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Events
{
    public class ProcessEventArgs : EventArgs
    {
        public ICalculation Calculation { get; set; }
    }
}
