using System;
using System.Collections.Generic;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using CalculatorProject.Events;
using System.Text;

namespace CalculatorProject.Events
{
    public delegate void Notify();
    public class ProcessCalcFunction
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        public double StartProcess()
        {
            var data = new ProcessEventArgs();

            try
            {
                Console.WriteLine("Process Started!");

                //arrange
                double _a = 1;
                double _b = 2;
                string op = Console.ReadLine();

                Func<double, double, double> _c = Operations.Sum;
                Calculator _calculator = new Calculator(new Builder());
                var _function = _calculator.RegularCalculator(_a, _b, _c);
                var _answer = _function.GetResult();

                data.IsSuccessful = true;
                return _answer;
                
            }
            catch (Exception ex)
            {
                data.IsSuccessful = false;
                data.CompletionTime = DateTime.Now;
                OnProcessCompleted(data);
                return 0;
            }
        }
        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
 }
