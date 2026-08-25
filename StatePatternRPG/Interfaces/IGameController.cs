using StatePatternRPG.Code;

namespace StatePatternRPG.Interfaces
{
    internal interface IGameController
    {
        public GameCommand GetInput();
    }
}
