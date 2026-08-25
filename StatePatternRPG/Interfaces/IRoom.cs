using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternRPG.Interfaces
{
    internal interface IRoom
    {
        public void Interact();
        public void Attack();
        public bool CanContinue();
        public void Observe();
        public void Proceed();
    }
}
