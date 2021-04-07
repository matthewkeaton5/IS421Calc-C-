using System;
using CalculatorProject;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using ConsoleAppProject.Events;
using System.Linq;
namespace ConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalcs = true;
            var _publisher = new Publisher();
            var _subscriber = new Subscriber();


            //Calculator class instantiation into a calculator object
            while (continueCalcs)
            {
                var builder = new Builder();
                Calculator _calculator = new Calculator(builder);
                CalculatorConsole console = new CalculatorConsole();
                var _op = console.userInput();
                string _historyOp = console.getHistoryOp();
                if (_historyOp != "invalid")
                {
                    dynamic _val1 = console.Values();
                    try
                    {
                        console.addListHistory(_val1, _historyOp);
                        console.CompleteCalculation(_val1, _op);
                        
                    }
                    catch(Exception e)
                    {
                        double _val2 = console.Values();
                        console.addHistory(_val1, _val2, _historyOp);
                        console.CompleteCalculation(_val1, _val2, _op);
                    }
                }
                else
                {
                    continue;
                }
                
            }
            
            


            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();
        }
    }
}
