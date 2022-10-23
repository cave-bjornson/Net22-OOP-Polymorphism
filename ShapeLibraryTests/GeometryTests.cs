using ShapeLibrary;

namespace ShapeLibraryTests
{
    public class ParallelogramTests
    {
        private readonly Parallelogram _parallelogram = new();

        [Fact]
        public void SetBase_ZeroOrBelow_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _parallelogram.Base = 0.0);
        }

        [Fact]
        public void SetHeight_ZeroOrBelow_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _parallelogram.Height = 0.0);
        }

        [Theory]
        [InlineData(0.0)]
        [InlineData(180.0)]
        public void SetThetaData_InRange_ThrowsNoException(double value)
        {
            var ex = Record.Exception(() => _parallelogram.AngleTheta = value);
            Assert.Null(ex);
        }

        [Theory]
        [InlineData(-0.1)]
        [InlineData(180.1)]
        public void SetThetaData_OutOfRange_ThrowsException(double value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _parallelogram.AngleTheta = value);
        }
    }

    public class EllipseTests
    {
        private readonly Ellipse _ellipse = new Ellipse();

        [Fact]
        public void SetMajorRadius_ZeroOrBelow_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _ellipse.MajorRadius = 0.0);
        }

        [Fact]
        public void SetMinorRadius_ZeroOrBelow_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _ellipse.MinorRadius = 0.0);
        }
    }
}
