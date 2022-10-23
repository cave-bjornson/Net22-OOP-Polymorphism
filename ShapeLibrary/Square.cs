namespace ShapeLibrary;

public class Square : Rectangle
{
    public Square() : this(5) { }

    public Square(double side) : base(@base: side, height: side) { }

    public override string ToString()
    {
        return $"{this.GetType().Name}: Side: {Base}, {nameof(Area)}: {Area():N2}";
    }
}
