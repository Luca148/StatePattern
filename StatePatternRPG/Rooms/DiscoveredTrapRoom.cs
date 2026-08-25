using StatePatternRPG.Code;
using StatePatternRPG.Definitions;
using StatePatternRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternRPG.Rooms
{
    internal class DiscoveredTrapRoom(Game game) : IRoom
    {
        private readonly Game _game = game;
        public void Attack()
        {
            Console.WriteLine(_game.Text.rooms.empty.attack);
        }

        public bool CanContinue() => true;

        public void Interact()
        {
            Console.WriteLine(_game.Text.rooms.trap.interact);
            _game.SetRoom(new EmptyRoom(_game));
        }

        public void Observe()
        {
            Console.WriteLine(_game.Text.rooms.trap.observe);
        }

        public void Proceed()
        {
            Console.WriteLine(_game.Text.rooms.trap.proceed);
            _game.SetRoom(new GameOverRoom());
        }
    }
}
