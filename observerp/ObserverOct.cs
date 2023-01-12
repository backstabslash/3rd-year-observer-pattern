using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerp
{
    internal class ObserverOct : IDisplayNum, IObserver
    {
        private string octnum;
        private int num;
        private ISubject subject;

        public ObserverOct(ISubject subject)
        {
            this.subject = subject;
            subject.registerObserver(this);
        }

        public void update(int num)
        {
            this.num = num;
            octnum = Convert.ToString(num, 8);
            display();
        }

        public void display()
        {
            Console.WriteLine("Received: {0}! In my oct(base 8) form it will be {1}.", num, octnum);
        }
    }
}
