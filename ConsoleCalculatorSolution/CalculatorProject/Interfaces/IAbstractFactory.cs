using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{
    interface IAbstractFactory
    {
        static IAbstractSingleCalculator CalcSingle() => new RegularFactory();
        static IAbstractBulkCalculator BulkCalc() => new Bulkfactory();

    }
    public interface IAbstractSingleCalculator
    {
        Calculation Create(double a, double b, Func<double, double, double> op);
    }

    interface IAbstractBulkCalculator
    {
        BulkCalculation Create(List<double> listOfValues, Func<List<double>, double> op);
    }
        
}

