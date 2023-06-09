namespace FunWithRecordStructs;

public record struct Point(double X, double Y, double Z);

public struct PointWithPropertySyntax
{
    public double X { get; set; } = default;
    public double Y { get; set; } = default;
    public double Z { get; set; } = default;

    public PointWithPropertySyntax(double x, double y, double z) : this()
    {
        X = x;
        Y = y;
        Z = z;
    }
}

    
