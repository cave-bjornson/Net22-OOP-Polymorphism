namespace ShapeLibrary;

public class Parallelogram : Geometry
{
    private double _angleTheta;
    private double _base;
    private double _height;

    public Parallelogram() : this(8.0, 10.0, 45.0) { }

    public Parallelogram(double @base, double height, double angleTheta)
    {
        Base = @base;
        Height = height;
        AngleTheta = angleTheta;
    }

    public double Base
    {
        get => _base;
        set
        {
            Shared.ValidatePositiveSetterValue(value);
            _base = value;
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            Shared.ValidatePositiveSetterValue(value);
            _height = value;
        }
    }

    public double AngleTheta
    {
        get => _angleTheta;
        set
        {
            if (value < 0.0 || 180.0 < value)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "the valid range is between 0.0 and 180.0"
                );
            }

            _angleTheta = value;
        }
    }

    public override double Area()
    {
        return Base * Height;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {nameof(Base)}: {Base}, {nameof(Height)}: {Height}, {nameof(AngleTheta)}: {AngleTheta}, {base.ToString()}";
    }
}
