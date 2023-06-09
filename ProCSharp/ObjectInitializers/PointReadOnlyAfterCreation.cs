namespace ObjectInitializers;

public class PointReadOnlyAfterCreation
{
    public int X { get; init; }
    public int Y { get; init; }

    public PointReadOnlyAfterCreation(int x, int y)
    {
        X = x;
        Y = y;
    }
}