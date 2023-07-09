using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    internal class CalculateLength
    {
        public void CalculateLengthOfLine()
        {
            Console.WriteLine("Enter the coordinates of the First point X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the First point Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the Second point x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the Second point Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double LengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The Length Of Line is:" + LengthOfLine);

        }
    }
}
