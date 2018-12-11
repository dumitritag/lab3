using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Strategy
{
    class Chesh : PaymentStrategy
    {
        public void pay(int amount)
        {
            Console.WriteLine(amount + " paid chesh.");
        }
    }
}
