using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using CalculatorProject.Events;
using System.Reflection;

namespace CalculatorProject.Tests
{
    

    [TestClass()]
    public class CalculatorTests
    {
        public static void _EventProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
        }

        [TestMethod()]
        public void CalculatorTest()
        {
            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));
        }

        [TestMethod()]
        public void SumTest()
        {

            ProcessCalcFunction _Event = new ProcessCalcFunction();
            _Event.ProcessCompleted += _EventProcessCompleted; // register with an event
             _Event.StartProcess();

            System.Diagnostics.Debug.WriteLine("Number Returned: " + _Event.StartProcess());
            Assert.AreEqual(_Event.StartProcess(), 3);
        }
        [TestMethod()]
        public void SubtractionTest()
        {
            //arrange
            double _a = 2;
            double _b = 1;
            Func<double, double, double> _c = Operations.Subtraction;
            Calculator _calculator = new Calculator(new Builder());

            var _function = _calculator.RegularCalculator(_a, _b, _c);
            var _answer = _function.GetResult();
            //Assert
            System.Diagnostics.Debug.WriteLine(_answer);
            Assert.AreEqual(_answer, 1);

            
        }
        [TestMethod()]
        public void MultiplicationTest()
        {
            //arrange
            double _a = 2;
            double _b = 2;
            Func<double, double, double> _c = Operations.Multiplication;
            Calculator _calculator = new Calculator(new Builder());

            var _function = _calculator.RegularCalculator(_a, _b, _c);
            var _answer = _function.GetResult();
            //Assert
            System.Diagnostics.Debug.WriteLine(_answer);
            Assert.AreEqual(_answer, 4);
        }
        [TestMethod()]
        public void DivisionTest()
        {
            //arrange
            double _a = 4;
            double _b = 2;
            Func<double, double, double> _c = Operations.Division;
            Calculator _calculator = new Calculator(new Builder());

            var _function = _calculator.RegularCalculator(_a, _b, _c);
            var _answer = _function.GetResult();
            //Assert
            System.Diagnostics.Debug.WriteLine(_answer);
            Assert.AreEqual(_answer, 2);
        }
        [TestMethod()]
        public void SumListTest()
        {
            //arrange
            //initialize a new list of numbers
            List<double> _values = new List<double> { 1, 2, 3, 4, 5, 6 };
            Func<List<double>, double> _operations = ListOperations.SumList;
            Calculator _calculator = new Calculator(new Builder());

            var _function = _calculator.BulkCalculator(_values, _operations);
            var _answer = _function.GetResult();
            //Assert
            System.Diagnostics.Debug.WriteLine(_answer);
            Assert.AreEqual(21, _answer);
        }


        }
}