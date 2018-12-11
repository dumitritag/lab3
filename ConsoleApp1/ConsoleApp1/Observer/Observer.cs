using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Observer
{
   public abstract class Observer
    {
        protected Pacient pacient;
        abstract public void update();
    }
}
