namespace ObjectInitializers;
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point() {}

    public void DisplayStatus()
    {
        Console.WriteLine("[{0}, {1}]", X, Y);
    }
    
}
