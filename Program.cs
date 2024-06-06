﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    { 

    
        public static void Main(string[] args) 
        {

            bool looper = true;

            Console.WriteLine("Please select a shape \n 1. Tripezium \n 2. Square \n 3. Triangle \n 4. Circle");
            int shape = int.Parse(Console.ReadLine());
      
           

            do
            {
                if (shape == 1)
                {

                    int a = 0, b = 0, h = 0;

                    Console.WriteLine("Please enter the tripezium length value");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the tripezium breath value");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the tripezium height value");
                    h = int.Parse(Console.ReadLine());

                    Tripezium tripezium = new Tripezium();

                    Console.WriteLine("The Area is: " + tripezium.getArea(a, b, h));
                    break;
                }

                else if (shape == 2)
                {
                    Console.WriteLine("Please enter the square side value");
                    int s = int.Parse(Console.ReadLine());

                    Square square = new Square();

                    Console.WriteLine("The Area is: " + square.getArea(s));
                    break;
                }

                else if (shape == 3)
                {
                    Console.WriteLine("Please enter the triangle breath value");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the triangle breath value");
                    int h = int.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle();

                    Console.WriteLine("The Area is: " + triangle.getArea(b, h));
                    break;
                }

                else if (shape == 4)
                {
                    Console.WriteLine("Please enter the circle radius value");
                    int r = int.Parse(Console.ReadLine());
            
             

                    Circle circle = new Circle();

                    Console.WriteLine("The Area is: " + circle.getArea(r));
                    break;
                }

                else 
                {

                    Console.WriteLine("Invalid selection \n Please select a correct shape: \n 1. Tripezium \n 2. Square \n 3. Triangle \n 4. Circle");
                    shape = int.Parse(Console.ReadLine());
                    looper = false;

                }

            }while (looper == false);
        }
    
    }

}