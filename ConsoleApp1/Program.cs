using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(6, 8, 10);
            Circle circle = new Circle(5);
            Console.WriteLine(Calculation.CalculateTheArea(triangle));
            Console.WriteLine(Calculation.CalculateTheArea(circle));
            Console.WriteLine(Calculation.ThisRectangular(triangle));
            Console.WriteLine(Calculation.ThisRectangular(circle));
            Console.ReadKey();
        }
    }
}
