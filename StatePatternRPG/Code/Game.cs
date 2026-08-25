using StatePatternRPG.Definitions;
using StatePatternRPG.Interfaces;

namespace StatePatternRPG.Code
{
    internal class Game(IGameController controller)
    {
        private enum RoomType
        {
            Empty,
            Trap,
            Enemy,
            GameOver,
            TrapDiscovered
        }

        private IGameController _gameController = controller;
        private RoomType _room = RoomType.Empty;
        private RpgText _text = new();

        private Random _random = new();
        public void Run()
        {
            while (CanContinue())
            {
                switch (_gameController.GetInput())
                {
                    case GameCommand.Attack:
                        Attack();
                        break;
                    case GameCommand.Proceed:
                        Proceed();
                        break;
                    case GameCommand.Observe:
                        Observe();
                        break;
                    case GameCommand.Interact:
                        Interact();
                        break;
                }

            }
        }

        private void Interact()
        {
            switch (_room)
            {
                case RoomType.TrapDiscovered:
                    Console.WriteLine(_text.rooms.trap.interact);
                    _room = RoomType.Empty;
                    break;
                case RoomType.Enemy:
                    Console.WriteLine(_text.rooms.enemy.interact);
                    break;
                default:
                    Console.WriteLine(_text.rooms.empty.interact);
                    break;
            }
        }

        private void Observe()
        {
            switch (_room)
            {
                case RoomType.Trap:
                    Console.WriteLine(_text.rooms.trap.observe);
                    _room = RoomType.TrapDiscovered;
                    break;
                case RoomType.Enemy:
                    Console.WriteLine(_text.rooms.enemy.observe);
                    break;
                default:
                    Console.WriteLine(_text.rooms.empty.observe);
                    break;
            }
        }

        private void Proceed()
        {
            switch (_room)
            {
                case RoomType.Trap:
                    Console.WriteLine(_text.rooms.trap.proceed);
                    _room = RoomType.GameOver;
                    break;
                case RoomType.TrapDiscovered:
                    Console.WriteLine(_text.rooms.trap.proceed);
                    _room = RoomType.GameOver;
                    break;
                case RoomType.Enemy:
                    Console.WriteLine(_text.rooms.enemy.proceed);
                    _room = RoomType.GameOver;
                    return;
                default:
                    break;
            }
            Console.WriteLine(_text.rooms.empty.proceed);
            _room = GetRandomRoom();
        }

        private void Attack()
        {
            switch (_room)
            {
                case RoomType.Enemy:
                    Console.WriteLine(_text.rooms.enemy.attack);
                    _room = RoomType.Empty;
                    break;
                default:
                    Console.WriteLine(_text.rooms.empty.attack);
                    break;
            }
        }

        private bool CanContinue()
        {
            return _room != RoomType.GameOver;
        }

        private RoomType GetRandomRoom()
        {
            return (RoomType)_random.Next(0, 3);
        }
    }
}
