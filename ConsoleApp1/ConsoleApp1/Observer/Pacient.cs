using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Observer
{
    public class Pacient
    {
        private List<Observer> observers = new List<Observer>();
        private string state;
        public string getState()
        {
            return state;
        }
        public void setState(string state)
        {
            this.state = state;
            notifyAllObservers();
        }
        public void attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void notifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }
    }
}
