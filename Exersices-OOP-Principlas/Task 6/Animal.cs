using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public abstract string Sound();
    }
}
