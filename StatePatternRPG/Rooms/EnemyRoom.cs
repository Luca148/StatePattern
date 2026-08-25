using StatePatternRPG.Code;
using StatePatternRPG.Interfaces;

namespace StatePatternRPG.Rooms
{
    internal class EnemyRoom(Game game) : IRoom
    {
        private readonly Game _game = game;
        public void Attack()
        {
            Console.WriteLine(_game.Text.rooms.enemy.attack);
            _game.SetRoom(new EmptyRoom(_game));
        }

        public bool CanContinue() => true;

        public void Interact()
        {
            Console.WriteLine(_game.Text.rooms.enemy.interact);
        }

        public void Observe()
        {
            Console.WriteLine(_game.Text.rooms.enemy.observe);
        }

        public void Proceed()
        {
            Console.WriteLine(_game.Text.rooms.enemy.proceed);
            _game.SetRoom(new GameOverRoom());
        }
    }
}
