using System;
using System.Collections.Generic;
using ShapesAreaLib;

namespace ShapesAreaClient
{
    class Program
    {   
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Triangle(6, 7, 8),
                new Circle(10)
            }; 
            
            foreach(var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
            }
        }
    }
}
