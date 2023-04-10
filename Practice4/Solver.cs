using Practice4.task1;
using Practice4.task2;

namespace Practice4;

public class Solver
{
    public void Task1()
    {
        PrintHeaderTask(1);

        new PingPongGame(new Ping(), new Pong()).StartGame();
    }

    public void Task2()
    {
        PrintHeaderTask(2);

        Hunter hunterJack = new Hunter("Jack");
        Hunter hunterNick = new Hunter("Nick");
        Rabbit rabbit = new Rabbit();
        hunterJack.Observe(rabbit);
        hunterNick.Observe(rabbit);
        hunterNick.Observe(rabbit); // оскільки мисливець вже стежить за кролем, то при повторному визові метода, мисливець не додасть нового обробника подій
        Console.WriteLine("Rabbit рухається перший раз.");
        rabbit.MoveRandomly(0, 10, 0, 10);
        Console.WriteLine("Rabbit рухається другий раз.");
        rabbit.MoveRandomly(0, 10, 0, 10);
    }

    public void Task3()
    {
        PrintHeaderTask(3);

        Rabbit rabbit = new Rabbit();
        rabbit.GeolocationChanged += delegate(int x, int y)
        {
            Console.WriteLine($"Анонімний метод визначив наступні координати зайця: x = {x}, y = {y}");
        };
        rabbit.GeolocationChanged += (x, y) =>
            Console.WriteLine($"Лямбда вираз визначив наступні координати зайця: x = {x}, y = {y}");
        Console.WriteLine("Rabbit рухається перший раз.");
        rabbit.MoveRandomly(0, 10, 0, 10);
        Console.WriteLine("Rabbit рухається другий раз.");
        rabbit.MoveRandomly(0, 10, 0, 10);
    }

    private void PrintHeaderTask(int number)
    {
        Console.WriteLine("Task {0}", number);
    }
}