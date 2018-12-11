using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.State
{
    class Empty : State
    {
        public void doAction()
        {
            Console.WriteLine("The room is empty, you can add a patient!");
        }
    }
}
