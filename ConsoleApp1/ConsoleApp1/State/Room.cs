using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.State
{
    class Room : State
    {
        private State roomState;
        public void setState(State state)
        {
            this.roomState = state;
        }
        public State getState()
        {
            return this.roomState;
        }
    public void doAction()
        {
            this.roomState.doAction();
        }
    }
}
