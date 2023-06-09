using SimpleClassExample;

Console.WriteLine("Fun With Class Types\n");

Car myCar = new();
myCar.petName = "Henry";
myCar.currSpeed = 10;

for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Motorcycle c = new Motorcycle(5);
