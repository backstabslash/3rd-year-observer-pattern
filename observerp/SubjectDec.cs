using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerp
{
    internal class SubjectDec : ISubject
    {
        private List<IObserver> observers;
        private int num;
        public SubjectDec()
        {
            observers = new List<IObserver>();
        }
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.RemoveAt(i);
        }
        public void notifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.update(num);
            }
        }
        public void numChanged()
        {
            notifyObservers();
        }
        public void setNum(int num)
        {
            this.num = num;
            numChanged();
        }
    }
}
