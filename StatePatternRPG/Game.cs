namespace StatePatternRPG
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

        private Random _random = new();
        public void Run()
        {
            while(CanContinue())
            {
                switch(_gameController.GetInput())
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

                    _room = RoomType.Empty;
                    break;
                case RoomType.Enemy:
                    //interact enemy
                    break;
                default:
                    //interact empty
                    break;
            }
        }

        private void Observe()
        {
            switch (_room)
            {
                case RoomType.Trap:
                    //trap found
                    _room = RoomType.TrapDiscovered;
                    break;
                case RoomType.Enemy:
                    //observe enemy
                    break;
                default:
                    //observe empty
                    break;
            }
        }

        private void Proceed()
        {
            switch (_room)
            {
                case RoomType.Trap:
                    _room = RoomType.GameOver;
                    //tod dialog
                    break;
                case RoomType.TrapDiscovered:
                    //tod dialog
                    _room = RoomType.GameOver;
                    break;
                case RoomType.Enemy:
                    _room = RoomType.GameOver;
                    //tod dialog
                    return;
                default:
                    break;
            }
            //proceed dialog
            _room = GetRandomRoom();
        }

        private void Attack()
        {
            switch (_room)
            {
                case RoomType.Enemy:
                    _room = RoomType.Empty;
                    //dialog kill enemy
                    break;
                default:
                    //empty attack
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
