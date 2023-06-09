namespace SimpleClassExample;

public class Motorcycle
{
    public int driverIntensity;
    public string driverName;

    public void SetDriverName(string name)
    {
        driverName = name;
    }
    
    public void PopAWheely()
    {
        for (int i = 0; i <= driverIntensity; i++)
        {
            Console.WriteLine("Yeeeeeeeeee Haaaaaaaaaaaawww!");    
        }
    }

    public Motorcycle(int intensity = 0, string name = "")
    {
        Console.WriteLine("In main constructor");
        if (intensity > 10)
        {
            intensity = 10;
        }

        driverIntensity = intensity;
        driverName = name;
    }
}