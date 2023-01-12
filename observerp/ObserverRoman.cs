using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerp
{
    internal class ObserverRoman : IDisplayNum, IObserver
    {
        private string romannum;
        private int num;
        private ISubject subject;
        string[] romanLetters = 
            {
            "M",
            "CM",
            "D",
            "CD",
            "C",
            "XC",
            "L",
            "XL",
            "X",
            "IX",
            "V",
            "IV",
            "I"
            };
        int[] numbers = 
            {
            1000,
            900,
            500,
            400,
            100,
            90,
            50,
            40,
            10,
            9,
            5,
            4,
            1
            };
        public ObserverRoman(ISubject subject)
        { 
            this.subject = subject;
            subject.registerObserver(this);
        }

        public string convert(int num)
        {
            string roman = "";
            if (num <= 0 || num > 5000) return roman;
            int i = 0;
            while (num != 0)
            {
                if (num >= numbers[i])
                {
                    num -= numbers[i];
                    roman += romanLetters[i];
                }
                else
                    i++;
            }
            return roman;
        }
        public void update(int num)
        {
            this.num = num;
            romannum = convert(num);
            display();
        }

        public void display()
        {
            if (num < 0)
                Console.WriteLine("Received: {0}, which is lower or equals to 0, no way I'm converting it into roman system...", num);
            else if (num > 1000)
                Console.WriteLine("Received: {0}, which is way too much for me. My maximum is only around MMMMM.", num);
            else
                Console.WriteLine("Received: {0}! Roman number for that will be {1}.", num, romannum);
        }
    }
}
