using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Observer
{
    public class Nurse : Observer
    {
        public Nurse(Pacient pacient)
        {
            this.pacient = pacient;
            this.pacient.attach(this);
        }
        public override void update()
        {
            Console.WriteLine("Stare: " + pacient.getState());
        }
    }
}
