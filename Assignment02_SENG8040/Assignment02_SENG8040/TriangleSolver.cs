using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02_SENG8040
{
    public static class TriangleSolver
    {
         public static string Analyze(int sidea, int sideb, int sidec)
         {
            if ((sidea + sideb) > sidec)
            {
                if ((sideb + sidec) > sidea)
                {
                    if ((sidea + sidec) > sideb)
                    {
                        Console.WriteLine("Triangle is Valid");
                        if (sidea == sideb && sideb == sidec)
                        {
                            Console.WriteLine("This is an equilateral triangle.");
                            return "This is an equilateral triangle.";
                        }
                        else if (sidea == sideb || sidea == sidec || sideb == sidec)
                        {
                            Console.WriteLine("This is an isosceles triangle.");
                            return "This is an isosceles triangle.";
                        }
                        else
                        {
                            Console.WriteLine("This is a scalene triangle.");
                            return "This is a scalene triangle.";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Triangle is not valid.");
                        return "Triangle is not valid.";
                    }
                }
                else
                {
                    Console.WriteLine("Triangle is not valid");
                    return "Triangle is not valid.";
                }
            }
            else
            {
                Console.WriteLine("Triangle is not valid");
                return "Triangle is not valid.";
            }
        }
    }
}
