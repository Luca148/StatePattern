namespace StatePatternRPG
{
    internal class ConsoleGameController : IGameController
    {
        public GameCommand GetInput()
        { 
            while (true)
            {
                switch(Console.ReadLine())
                {
                    case "attack":
                        return GameCommand.Attack;
                    case "interact":
                        return GameCommand.Interact;
                    case "observe":
                        return GameCommand.Observe;
                    case "proceed":
                        return GameCommand.Proceed;
                    default:
                        Console.WriteLine("Invalid Command, valid Commands are: proceed, interact, attack, observe");
                        break;
                }
            }

        }
    }
}
