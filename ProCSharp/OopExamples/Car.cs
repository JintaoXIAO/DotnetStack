namespace OopExamples;

public class Car
{
    private Radio myRadio = new();

    public void TurnOnRadio(bool onOff)
    {
        myRadio.Power(onOff);
    }
}