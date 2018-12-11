using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.State
{
    class Full : State
    {
        public void doAction()
        {
            Console.WriteLine("The room is full, you can not add a patient!");
        }
    }
}
