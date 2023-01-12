using System;
using System.Collections.Generic;

namespace observerp
{
    internal class ObsPatternExample
    {
        static void Main(string[] args)
        {
            SubjectDec subject = new SubjectDec();

            ObserverBin binaryobs = new ObserverBin(subject);
            ObserverOct octalobs = new ObserverOct(subject);
            ObserverHex hexadecobs = new ObserverHex(subject);
            ObserverRoman romanobs = new ObserverRoman(subject);

            subject.setNum(-23);
            Console.WriteLine();
            subject.setNum(15);
            Console.WriteLine();
            subject.setNum(256);
            Console.WriteLine();
            subject.setNum(10000);
        }
    }
}