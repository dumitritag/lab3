using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Strategy
{
    class Card : PaymentStrategy
    {
        private String name;
        private String cardNumber;
        private String cvv;
        private String dateOfExpiry;

        public Card(String nm, String ccNum, String cvv, String expiryDate)
        {
            this.name = nm;
            this.cardNumber = ccNum;
            this.cvv = cvv;
            this.dateOfExpiry = expiryDate;
        }
    public void pay(int amount)
        {
            Console.WriteLine(amount + " paid with credit/debit card.");
        }
    }
}
