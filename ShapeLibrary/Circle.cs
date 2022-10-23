namespace ShapeLibrary;

public class Circle : Ellipse
{
    public Circle() : this(5.0) { }

    public Circle(double radius) : base(majorRadius: radius, minorRadius: radius) { }

    public override string ToString()
    {
        return $"{this.GetType().Name}: Radius: {MajorRadius}, {nameof(Area)}: {Area():N2}";
    }
}
