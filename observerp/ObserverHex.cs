using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerp
{
    internal class ObserverHex : IDisplayNum, IObserver
    {
        private string hexnum;
        private int num;
        private ISubject subject;

        public ObserverHex(ISubject subject)
        {
            this.subject = subject;
            subject.registerObserver(this);
        }

        public void update(int num)
        {
            this.num = num;
            hexnum = Convert.ToString(num, 16).ToUpper();
            display();
        }

        public void display()
        {
            Console.WriteLine("Received: {0}! In my hex(base 16) form it will be {1}.", num, hexnum);
        }
    }
}
