using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the unit-under-test
            var uut = new Calculatorclass();

            // Test Add()
            Console.WriteLine("Add({0}, {1}) = {2}", 3.5, 2.5, uut.Add(3.5, 2.5));
            Console.WriteLine("Add({0}, {1}) = {2}", -3.5, 2.5, uut.Add(-3.5, 2.5));
            Console.WriteLine("Add({0}, {1}) = {2}", -3.5, -2.5, uut.Add(-3.5, -2.5));

            // Test Subtract()
            Console.WriteLine("Subtract({0}, {1}) = {2}", 3.5, 2.5, uut.Subtract(3.5, 2.5));
            Console.WriteLine("Subtract({0}, {1}) = {2}", -3.5, 2.5, uut.Subtract(-3.5, 2.5));
            Console.WriteLine("Subtract({0}, {1}) = {2}", -3.5, -2.5, uut.Subtract(-3.5, -2.5));

            // Test Multiply()
            Console.WriteLine("Multiply({0}, {1}) = {2}", 3.5, 2.5, uut.Multiply(3.5, 2.5));
            Console.WriteLine("Multiply({0}, {1}) = {2}", -3.5, 2.5, uut.Multiply(-3.5, 2.5));
            Console.WriteLine("Multiply({0}, {1}) = {2}", -3.5, -2.5, uut.Multiply(-3.5, -2.5));

            // Test Power()
            Console.WriteLine("Power({0}, {1}) = {2}", 2.0, 3.0, uut.Power(2.0, 3.0));
            Console.WriteLine("Power({0}, {1}) = {2}", -2.0, 3.0, uut.Power(-2.0, 3.0));
            Console.WriteLine("Power({0}, {1}) = {2}", -2.0, -3.0, uut.Power(-2.0, -3.0));

        }
    }
}
