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
    class Subscriber
    {

        public void CompleteCalculation(object source, ProcessConsoleEventArgs e)
        {
            try
            {
                OnCompleteCalculation(e.a, e.b, e.op);
            }
            catch
            {
                OnCompleteCalculation(e.listOfValues, e.listOp);
            }
        }

        protected virtual void OnCompleteCalculation(double val1, double val2, Func<double, double, double> op)
        {

            var _answer = initialize().CreateCalculation(val1, val2, op);
            Console.WriteLine("Answer:" + _answer.GetResult());

        }
        protected virtual void OnCompleteCalculation(List<double> listOfValues, Func<List<double>, double> op)
        {
            var _answer = initialize().CreateCalculation(listOfValues, op);

            Console.WriteLine("Answer:" + _answer.GetResult());
        }
        public Calculator initialize()
        {
            var builder = new Builder();
            Calculator _calculator = new Calculator(builder);
            return _calculator;
        }
    }

}
