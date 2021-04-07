using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using CalculatorProject.Interfaces;
using CalculatorProject.Events;
using CalculatorProject;
using ConsoleAppProject.Events;
using Microsoft.VisualBasic.CompilerServices;
using System.Linq;

namespace ConsoleAppProject
{
    class UseHistory
    {
        int historyCount = 1;


        Dictionary<int, Tuple<double, double, string>> history = new Dictionary<int, Tuple<double, double, string>>();
        Dictionary<int, Tuple<object, string>> Listhistory = new Dictionary<int, Tuple<object, string>>();

        public void addHistory(double a, double b, string op)
        {
           double _A = a;
           double _B = b;
           string _Op = op;
            history.Add(historyCount, SetHistory(_A,_B,_Op));
            historyCount++;
        }
        public void addListHistory(List<double> listOfValues, string op)
        {
            List<double> _listOfValues = listOfValues;
            string _op = op;
            Listhistory.Add(historyCount, SetListHistory(_listOfValues, _op));
            historyCount++;
        }
        public void getHistory()
        {
            Console.WriteLine("This is your History");
            foreach (var x  in history)
            {

                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("This is your List History");

            Listhistory.Select(i => $"{i.Key}: {i.Value.ToString()}").ToList().ForEach(Console.WriteLine);

        }
        public Tuple<double, double, string> SetHistory(double a, double b, string op)
        {
            double _A = a;
            double _B = b;
            string _Op = op;
            return Tuple.Create(_A, _B, _Op);
        }
        public Tuple<object, string> SetListHistory(List<double> listOfValues, string op)
        {
            List<string> list = new List<string>();
            string _op = op;
            var listFinal = Tuple.Create(listhistory(listOfValues), _op);
            return listFinal;
        }

        public object listhistory(List<double> listOfValues)
        {
            var result = String.Join(",", listOfValues.ToArray());
            return result;
        }
    }
}
