using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Events
{
    public class Publisher : EventArgs
    {
        public EventHandler<ProcessEventArgs> _completed;
        public void setCalculation(ICalculation calculation)
        {
            OnCalculation(calculation);
        }
        protected virtual void OnCalculation(ICalculation calculation)
        {
            if (_completed != null)
            {
                _completed.Invoke(this, new ProcessEventArgs() { Calculation = calculation });
            }
        }
    }
}
