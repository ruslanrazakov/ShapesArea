namespace ShapesAreaLib
{
    public class ShapeZeroParameterException : System.Exception
    {
        public ShapeZeroParameterException(string message) : base(message) { }
    }

    public class ShapeWrongParameterException : System.Exception
    {
        public ShapeWrongParameterException(string message) : base(message) { }
    }
}