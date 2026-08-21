using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternRPG
{
    internal interface IGameController
    {
        public GameCommand GetInput();
    }
}
