namespace Practice4.task2;

public class Hunter
{
    private string _name;
    private HashSet<Rabbit> _observedRabbits;
    public Hunter(string name)
    {
        _name = name;
        _observedRabbits = new HashSet<Rabbit>();
    }

    private void DisplayRabbitGeolocation(int x, int y)
    {
        Console.WriteLine($"Hunter {_name} говорить, що координати зайця тепер: x = {x}, y = {y}");
    }

    public void Observe(Rabbit rabbit)
    {
        if (_observedRabbits.Contains(rabbit))
        {
            return;
        }

        _observedRabbits.Add(rabbit);
        rabbit.GeolocationChanged += DisplayRabbitGeolocation;
    }
}