﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string Sound()
        {
            return "RRRRRR-bit";
        }
    }
}
