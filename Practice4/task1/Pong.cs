namespace Practice4.task1;

public class Pong
{
    public delegate void PongHandler(string message);

    public event PongHandler PongExecuted;

    public void MakePong(string message)
    {
        Console.WriteLine("Pong приймає: {0}", message);
        Thread.Sleep(5000);
        Console.WriteLine("Pong виконує понг.");
        PongExecuted("Виконано понг від Pong");
    }
}