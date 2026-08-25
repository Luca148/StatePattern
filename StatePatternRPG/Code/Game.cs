using StatePatternRPG.Definitions;
using StatePatternRPG.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace StatePatternRPG.Code
{
    internal class Game
    {
        private IGameController _gameController;
        private IRoom _room;
        private RpgText _text = new();
        public RpgText Text { get { return _text; } }
        public Game(IGameController controller)
        {
            _gameController = controller;
            _room = new Rooms.EmptyRoom(this);
        }

        private Random _random = new();
        public void Run()
        {
            while (_room.CanContinue())
            {
                switch (_gameController.GetInput())
                {
                    case GameCommand.Attack:
                        _room.Attack();
                        break;
                    case GameCommand.Proceed:
                        _room.Proceed();
                        break;
                    case GameCommand.Observe:
                        _room.Observe();
                        break;
                    case GameCommand.Interact:
                        _room.Interact();
                        break;
                }

            }
        }

        public void SetRoom(IRoom room)
        {
            _room = room;
        }

        public IRoom GetRandomRoom()
        {
            return _random.Next(0, 3) switch
            {
                0 => new Rooms.EmptyRoom(this),
                1 => new Rooms.TrapRoom(this),
                2 => new Rooms.EnemyRoom(this),
                _ => throw new Exception()
            };
        }
    }
}
