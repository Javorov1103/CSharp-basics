using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6
{
    class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string Sound()
        {
            return "Meow";
        }
    }
}
