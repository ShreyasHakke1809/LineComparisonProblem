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
            Console.WriteLine("Enter the coordinates for the First line:");
            Console.WriteLine("Enter the coordinates of the First point X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the First point Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the Second point x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the Second point Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates for the Second line:");
            Console.WriteLine("Enter the coordinates of the First point X3:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the First point Y3:");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the Second point x4:");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the Second point Y4:");
            double y4 = Convert.ToDouble(Console.ReadLine());

            double LengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The Length Of Line 1 is:" + LengthOfLine);

            double LengthOfLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("The Length Of Line 2 is:" + LengthOfLine2);

            double diff = LengthOfLine.CompareTo(LengthOfLine2);
            if (diff < 0)
            {
                Console.WriteLine("Length of Line 1 is less than Line2");
            }
            else if (diff > 0)
            {
                Console.WriteLine("Length of Line 1 is greater than Line2");
            }
            else if (diff == 0)
            {
                Console.WriteLine("Length of Line 1 equal to Line2");
            }
        }
    }
}
