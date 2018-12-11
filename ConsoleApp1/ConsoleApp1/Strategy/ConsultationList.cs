using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Strategy
{
    class ConsultationList
    {
        List<Consultation> consultations;
        public ConsultationList()
        {
            this.consultations = new List<Consultation>();
        }
        public void addConsultation(Consultation consultation)
        {
            this.consultations.Add(consultation);
        }

        public int calculateTotal()
        {
            int sum = 0;
            foreach (Consultation consultation in consultations)
            {
                sum += consultation.getPrice();
            }
            return sum;
        }
        public void pay(PaymentStrategy paymentMethod)
        {
            int amount = calculateTotal();
            paymentMethod.pay(amount);
        }
    }
}
