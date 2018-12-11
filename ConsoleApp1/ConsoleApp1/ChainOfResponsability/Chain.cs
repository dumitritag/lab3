using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ChainOfResponsability
{
    public class Chain
    {
        private static Random RANDOM = new Random();
        private static int nextID = 1;
        private int id = nextID++;

        public bool execute(Investigate inv)
        {
            if (RANDOM.Next(3) != 0)
            {
                Console.WriteLine(" Doctor " + id + " is busy.");
                return false;
            }
            Console.WriteLine("Doctor " + id + " - " + inv.investigatePacient());
            return true;
        }

    }
}
