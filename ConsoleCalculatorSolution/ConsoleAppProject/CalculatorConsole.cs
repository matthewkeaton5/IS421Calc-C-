using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using CalculatorProject;
using System.Linq;
using ConsoleAppProject.Events;


namespace ConsoleAppProject
{
    class CalculatorConsole
    {
        public static Calculator _calculator = new Calculator(new Builder());
        public static Calculation _calculation = new Calculation();
        public static UseHistory _history = new UseHistory();
        //private Publisher _publisher = new Publisher();
        //private Subscriber _subscriber = new Subscriber();
        string historyOp = "";
        
        public dynamic userInput()
        {
            Console.WriteLine("Please select one...  Add, Subtract, Multiply, Divide, ListAdd, or History");

            string _answer = Console.ReadLine();

            switch (_answer.ToLower())
            {
                case "add":
                    Func<double, double, double> _op = Operations.Sum;
                    Console.WriteLine("Please enter what you would like to add...");
                    historyOp = "Add";
                    return _op;
                case "listadd":
                    Func<List<double>, double> _listOp = ListOperations.SumList;
                    historyOp = "SumList";
                    return _listOp;
                case "subtract":
                    _op = Operations.Subtraction;
                    Console.WriteLine("Please enter what you would like to subtract...");
                    historyOp = "Subtraction";
                    return _op;
                case "multiply":
                    _op = Operations.Multiplication;
                    Console.WriteLine("Please enter what you would like to multiply...");
                    historyOp = "Multiplication";
                    return _op;
                case "divide":
                    _op = Operations.Division;
                    Console.WriteLine("Please enter what you would like to Division...");
                    historyOp = "Division";
                    return _op;
                case "history":
                    getHistory();
                    historyOp = "invalid";
                    return _op = Operations.Unassigned;
                //case "use history":
                default:
                    historyOp = "invalid";
                    Console.WriteLine("Incorrect");
                    return _op = Operations.Unassigned;
                
            }
        }
        public dynamic Values()
        {
            {
                bool trying = true;
                while (trying)
                {
                    Console.WriteLine("Please enter a number: ");
                    string _Val = Console.ReadLine();
                    try
                    {
                        List<string> listOfStrings = _Val.Split(",").ToList();
                        string check = listOfStrings[1];
                        
                        List<double> listOfValues  = new List<double>();
                        foreach(var singleString in listOfStrings)
                        {
                            listOfValues.Add(Convert.ToDouble(singleString));
                        }
                        return listOfValues;
                        
                    }
                    catch(Exception e)
                    {
                        try
                        {
                            trying = false;
                            return Convert.ToDouble(_Val);
                        }
                        catch
                        {
                            Console.WriteLine("Value input must be a number!");
                        }
                    }
                    
                }
                return 0;


            }
        }

        public string getHistoryOp()
        {
            return historyOp;
        }
        public void addHistory(double a, double b, string op)
        {

            _history.addHistory(a,b,op);
        }
        public void addListHistory(List<double> listOfValues, string op)
        {

            _history.addListHistory(listOfValues,op);
        }

        public void CompleteCalculation(double val1, double val2, Func<double, double, double> op)
        {
            var _publisher = new Publisher();
            var _subscriber = new Subscriber();

            var _answer = _calculator.CreateCalculation(val1, val2, op);
            
            _publisher.UserInputComplete += _subscriber.CompleteCalculation;
            _publisher.CreateUserinput(val1, val2, op);
            _publisher.CreateCalculation(_answer);

            //Console.WriteLine("Answer:" + _answer.GetResult());

        }
        public void CompleteCalculation(List<double> listOfValues, Func<List<double>, double> op)
        {
            var _publisher = new Publisher();
            var _subscriber = new Subscriber();

            var _answer = _calculator.CreateCalculation(listOfValues, op);
            _publisher.UserInputComplete += _subscriber.CompleteCalculation;
            _publisher.CreateUserinput(listOfValues, op);
            _publisher.CreateCalculation(_answer);

            //Console.WriteLine("Answer:" + _answer.GetResult());
        }

        public void getHistory()
        {
            _history.getHistory();
        }
    }
}
