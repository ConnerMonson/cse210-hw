using System.Formats.Asn1;

class Rectangle: Shape
{
    private double _width;
    private double _length;
    public Rectangle(string color, double width, double length): base(color)
    {
        _width = width;
        _length = length;
    }
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}