using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerp
{
    internal class ObserverBin : IDisplayNum, IObserver
    {
        private string binnum;
        private int num;
        private ISubject subject;

        public ObserverBin(ISubject subject)
        {
            this.subject = subject;
            subject.registerObserver(this);
        }

        public void update(int num)
        {
            this.num = num;
            binnum = Convert.ToString(num, 2);
            display();
        }

        public void display()
        {
            if (num < 0)
                Console.WriteLine("Received: {0}, which is lower than 0, sadly I can't convert such number into binary...", num);
            else Console.WriteLine("Received: {0}! In my bin(base 2) form it will be {1}.", num, binnum);
        }
    }
}
