using System;
using CalculatorProject;
using CalculatorProject.Events;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
namespace ConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator class instantiation into a calculator object
            var builder = new Builder();

            Calculator _calculator = new Calculator(builder);

           

         

            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();
        }
    }
}
