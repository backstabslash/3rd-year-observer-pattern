using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerp
{
    internal interface IObserver
    {
        public void update(int num);
    }
}
