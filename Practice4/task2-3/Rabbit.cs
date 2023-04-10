namespace Practice4.task2;

public class Rabbit
{
    public delegate void RabbitGeolocaion(int x, int y);

    public event RabbitGeolocaion GeolocationChanged;
    private int _x;
    private int _y;

    public void MoveRandomly(int minX, int maxX, int minY, int maxY)
    {
        Random random = new Random();
        _x = random.Next(minX, maxX + 1);
        _y = random.Next(minY, maxY + 1);
        GeolocationChanged(_x,_y);
    }

    public void DisplayInfo()
    {
        Console.WriteLine(_x);
        Console.WriteLine(_y);
    }
}