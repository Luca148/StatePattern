using StatePatternRPG.Code;
using StatePatternRPG.Interfaces;

namespace StatePatternRPG.Rooms
{
    internal class EmptyRoom(Game game) : IRoom
    {
        private Game _game = game;
        public void Attack()
        {
            Console.WriteLine(_game.Text.rooms.empty.attack);
        }

        public bool CanContinue() => true;

        public void Interact()
        {
            Console.WriteLine(_game.Text.rooms.empty.interact);
        }

        public void Observe()
        {
            Console.WriteLine(_game.Text.rooms.empty.observe);
        }

        public void Proceed()
        {
            Console.WriteLine(_game.Text.rooms.empty.proceed);
            _game.SetRoom(_game.GetRandomRoom());
        }
    }
}
