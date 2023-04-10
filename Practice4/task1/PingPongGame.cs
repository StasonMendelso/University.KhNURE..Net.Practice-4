namespace Practice4.task1;

public class PingPongGame
{
    private Ping _ping;
    private Pong _pong;

    public PingPongGame(Ping ping, Pong pong)
    {
        _ping = ping;
        _pong = pong;
        _ping.PingExecuted += _pong.MakePong;
        _pong.PongExecuted += _ping.MakePing;
    }

    public void StartGame()
    {
        _pong.MakePong("Перший пінг");
    }
}