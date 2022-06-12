using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Dog : Animal
    {
        public decimal SpeedOfRunning { get; set; }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            private set { myVar = value; }
        }

    }
}
