using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            this._state = state;
            NotifyAllObservers();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }


    }
}
