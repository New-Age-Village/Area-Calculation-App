using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Area
    {

        public double getArea(int a)
        {
            return 0;
        }

    }

    public class Tripezium: Area
    {

        public double getArea(double a, double b, double h)
        {

            return 0.5 * (a + b) * h;

        }

    }

    public class Square : Area
    {

        public double getArea(double s)
        {

            return s*s;

        }

    }

    public class Triangle : Area
    {

        public double getArea(double b, double h)
        {

            return 0.5 * b * h;

        }

    }

    public class Circle : Area
    {
        double pi = Math.PI;
        public double getArea(double r)
        {

            return pi * r*r;

        }

    }

}
