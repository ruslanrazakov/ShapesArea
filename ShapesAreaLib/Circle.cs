using System;

namespace ShapesAreaLib
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }
 
        public Circle(int radius)
        {
            if(radius <= 0)
                throw new ShapeZeroParameterException("Value of circle radius must be greater than zero!");
            Radius = radius;
        }

        double IShape.GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;       
        }
    }
}