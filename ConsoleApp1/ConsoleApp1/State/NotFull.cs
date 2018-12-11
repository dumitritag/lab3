using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.State
{
    class NotFull : State
    {
        public void doAction()
        {
            Console.WriteLine("You can add one patient!");
        }
    }
}
