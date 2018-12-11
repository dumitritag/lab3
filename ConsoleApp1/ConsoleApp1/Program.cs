using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hospital Nr1");
            Console.WriteLine("**********************************");
            ChainOfResponsability.Investigate[] inv = { new ChainOfResponsability.DoctorA(), new ChainOfResponsability.DoctorB(), new ChainOfResponsability.DoctorC() };
            ChainOfResponsability.Chain[] chain = { new ChainOfResponsability.Chain(), new ChainOfResponsability.Chain(), new ChainOfResponsability.Chain() };
            for (int i = 0, j; i < inv.Length; i++)
            {
                Console.WriteLine("Operation #" + (i + 1) + ":");
                j = 0;
                while (!chain[j].execute(inv[i]))
                {
                    j = (j + 1) % chain.Length;
                }
}
                Console.ReadKey();
                Console.WriteLine("**************************");
                Observer.Pacient pacient = new Observer.Pacient();

                new Observer.Doctor(pacient);
                new Observer.Nurse(pacient);

                Console.WriteLine("First state change: good");
                pacient.setState("good");
                Console.WriteLine("\nSecond state change: bad");
                pacient.setState("bad");

                Console.ReadKey();
            Console.WriteLine("**********************");
            Command.MedicalRecord medicalRecord = new Command.MedicalRecord();
            Command.ActionListenerCommand clickOpen = new Command.ActionOpen(medicalRecord);
            Command.ActionListenerCommand clickSave = new Command.ActionSave(medicalRecord);
            Command.MenuOptions menu = new Command.MenuOptions(clickOpen, clickSave);
            menu.clickOpen();
            menu.clickSave();

            Console.ReadKey();

            Console.WriteLine("**********************");
            State.Room room = new State.Room();
            State.State emptyState = new State.Empty();
            State.State fullState = new State.Full();
            State.State notFullState = new State.NotFull();

            room.setState(emptyState);
            room.doAction();
            room.setState(fullState);
            room.doAction();
            room.setState(notFullState);
            room.doAction();

            Console.ReadKey();
            Console.WriteLine("**********************");

            Strategy.ConsultationList consultations = new Strategy.ConsultationList();
            Strategy.Consultation consultation1 = new Strategy.Consultation("Ginecology", 250);
            Strategy.Consultation consultation2 = new Strategy.Consultation("Cardiology", 350);
            consultations.addConsultation(consultation1);
            consultations.addConsultation(consultation2);
            consultations.pay(new Strategy.Chesh());
            consultations.pay(new Strategy.Card("Garaba Dumitrita", "173492429456789", "563", "09/20"));

            Console.ReadKey();
        }
    }
}
