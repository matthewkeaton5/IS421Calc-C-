using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using CalculatorProject.Events;
using CalculatorProject;

namespace ConsoleAppProject.Events
{
    class Publisher
    { 
        public delegate void UserInputEventHandler(object source, ProcessConsoleEventArgs args);
        public event UserInputEventHandler UserInputComplete;
        public event UserInputEventHandler CompletedCalculation;



        public void CreateCalculation(ICalculation _calculator)
        {
            OnCompletedCalculation(_calculator);
        }

        public void CreateUserinput(List<double> listOfValues, Func<List<double>, double> op)
        {
            OnUserInputComplete(listOfValues, op);
        }
        public void CreateUserinput(double val1, double val2, Func<double, double, double> op)
        {
            OnUserInputComplete(val1,val2,op);
        }
        protected virtual void OnUserInputComplete(List<double> listOfValues, Func<List<double>, double> op)
        {
            if (UserInputComplete != null)
            {
                UserInputComplete(this, new ProcessConsoleEventArgs() {listOfValues = listOfValues, listOp = op});
            }
        }
        protected virtual void OnUserInputComplete(double val1, double val2, Func<double, double, double> op)
        {
            if (UserInputComplete != null)
            {
                UserInputComplete(this, new ProcessConsoleEventArgs() { a = val1, b = val2, op = op});
            }
        }
        protected virtual void OnCompletedCalculation(ICalculation _calculator)
        {
            if (CompletedCalculation != null)
            {
                CompletedCalculation(this, new ProcessConsoleEventArgs() { UserInput = _calculator});

            }
        }
    }


}
