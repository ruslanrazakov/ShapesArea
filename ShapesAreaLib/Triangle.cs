using System;

namespace ShapesAreaLib
{
    public class Triangle : IShape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        private double HalfPerimeter
        {
            get => (SideA + SideB + SideC) / 2;
        }
        public bool IsRight { get; private set; }
 
        public Triangle(double sideA, double sideB, double sideC)
        {
            CheckParameters(sideA, sideB, sideC);
 
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private void CheckParameters(double sideA, double sideB, double sideC)
        {
            if(sideA <= 0 || sideB <= 0 || sideC <= 0)
                    throw new ShapeZeroParameterException("Value of triangle side must be greater than zero!");
            
            if(sideA + sideB <= sideC ||
               sideB + sideC <= sideA ||
               sideA + sideC <= sideB)
                    throw new ShapeWrongParameterException("The sum of two side lengths has to exceed the length of the third side!");
            
            if((sideA * sideA + sideB * sideB == sideC * sideC)  ||
                (sideA * sideA + sideC * sideC == sideB * sideB) || 
                (sideC * sideC + sideB * sideB == sideA * sideA))
                    IsRight = true;
        }
 
        double IShape.GetArea()
        {
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA) 
                                        * (HalfPerimeter - SideB) 
                                        * (HalfPerimeter - SideC));
        }
    }
}