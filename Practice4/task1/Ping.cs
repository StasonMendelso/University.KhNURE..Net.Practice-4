namespace Practice4.task1;

public class Ping
{
    public delegate void PingHandler(string message);

    public event PingHandler PingExecuted;


    public void MakePing(String message)
    {
        Console.WriteLine("Ping приймає: {0}", message);
        Thread.Sleep(5000);
        Console.WriteLine("Ping виконує пінг.");
        PingExecuted("Виконано пінг від Ping");
    }
}