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
    class ProcessConsoleEventArgs : EventArgs
    {
        public ICalculation UserInput { get; set; }
        public double a { get; set; }

        public double b { get; set; }

        public Func<double, double, double> op { get; set; }

        public List<double> listOfValues { get; set; }

        public Func<List<double>, double> listOp { get; set; }



    }
}
