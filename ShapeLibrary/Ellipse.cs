namespace ShapeLibrary;

public class Ellipse : Geometry
{
    private double _majorRadius;
    private double _minorRadius;

    public Ellipse() : this(3.0, 4.0) { }

    public Ellipse(double majorRadius, double minorRadius)
    {
        MajorRadius = majorRadius;
        MinorRadius = minorRadius;
    }

    public double MajorRadius
    {
        get => _majorRadius;
        set
        {
            Shared.ValidatePositiveSetterValue(value);
            _majorRadius = value;
        }
    }

    public double MinorRadius
    {
        get => _minorRadius;
        set
        {
            Shared.ValidatePositiveSetterValue(value);
            _minorRadius = value;
        }
    }

    public override double Area()
    {
        return MajorRadius * MinorRadius * Math.PI;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {nameof(MajorRadius)}: {MajorRadius}, {nameof(MinorRadius)}: {MinorRadius}, {base.ToString()}";
    }
}
