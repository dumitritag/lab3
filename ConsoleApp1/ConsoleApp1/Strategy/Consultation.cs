using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Strategy
{
    class Consultation
    {
        String name;
        private int price;

        public Consultation(String name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public String getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
