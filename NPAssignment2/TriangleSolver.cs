using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPAssignment2
{
    public static class EquilateralTriangle
    {

        public static string Analyze(int a1, int b1, int c1)
        {
            while (true)
            {

                string Result = "";

                // Numbers form taingle or NOT - A triangle is valid if sum of its two sides is greater than the third side.
                if (a1 + b1 <= c1 || a1 + c1 <= b1 || b1 + c1 <= a1)
                {
                    Result = ("Numbers not valid to form traingle");
                }

                // Equilateral triangle has all sides equal
                if (a1 == b1 && b1 == c1 && b1 == a1)
                {
                    Result += (a1 + b1 + c1) + ("Equilateral triangle");

                }
                //isosceles triangle has two sides of equal length
                else if (a1 == b1 || b1 == c1 || b1 == a1)
                {
                    Result += (a1 + b1 + c1) + ("Isosceles triangle");

                }
                //scalene triangle has three unequal sides
                else if (a1 != b1 && b1 != c1 && b1 != a1)
                {
                    Result += (a1 + b1 + c1) + ("Scalene triangle");

                }
                else
                {
                    Console.WriteLine("You must enter 3 integer numbers!");
                    Console.ReadLine();
                }

                return Result;

            }
        }

    }
}
