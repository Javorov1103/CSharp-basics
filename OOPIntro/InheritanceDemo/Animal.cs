using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public abstract class Animal
    {
        public int NumberOfLegs { get; set; }

        public int AverageLifeLenght { get; set; }

        public virtual void MyVirtualMethod()
        {
            Console.WriteLine("animal virtual method");
        }

        public abstract void MyAbstractMethod();


    }
}
