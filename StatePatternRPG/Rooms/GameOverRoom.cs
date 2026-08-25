using StatePatternRPG.Interfaces;

namespace StatePatternRPG.Rooms
{
    internal class GameOverRoom : IRoom
    {

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public bool CanContinue() => false;

        public void Interact()
        {
            throw new NotImplementedException();
        }

        public void Observe()
        {
            throw new NotImplementedException();
        }

        public void Proceed()
        {
            throw new NotImplementedException();
        }
    }
}
