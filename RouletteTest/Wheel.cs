namespace ProjektM320;

public class Wheel
{
    private Random _random = new Random();

    public int Spin()
    {
        return _random.Next(0, 37); // Numbers 0-36
    }
}