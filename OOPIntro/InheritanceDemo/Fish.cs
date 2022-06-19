using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Fish : Animal, IMovable
    {
        public decimal SpeedOfSwimming { get; set; }

        public void Move()
        {
            Console.WriteLine("Fish is swiming");
        }

        public override void MyAbstractMethod()
        {
            throw new NotImplementedException();
        }

        public override void MyVirtualMethod()
        {
            Console.WriteLine("Fish virtual method");
        }
    }
}
