namespace ShapeLibrary;

public class Rectangle : Parallelogram
{
    public Rectangle() : this(6.0, 8.0) { }

    public Rectangle(double @base, double height) : base(@base, height, 90.0) { }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {nameof(Base)}: {Base}, {nameof(Height)}: {Height}, {nameof(Area)}: {Area():N2}";
    }
}
