namespace StatePatternRPG.Code;
public class Program
{
    public static void Main(string[] args)
    {
        var game = new Game(new ConsoleGameController());
        game.Run();
    }
}