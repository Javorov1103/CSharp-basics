using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Dog : Animal, IMovable
    {
        private decimal speedOfRuning;
        public decimal SpeedOfRunning
        { 
            get 
            { 
                    return speedOfRuning;
            }
            set 
            { 
                if(value > 20)
                {
                    FastDog = true;
                }

                speedOfRuning = value;
            }
        }

        public bool FastDog { get; set; } = false;

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            private set { myVar = value; }
        }


        private void SetMyProperty()
        {
            MyProperty = 3;
        }

        public void Move()
        {
            Console.WriteLine("Dog is moving");
        }

        //public override void MyAbstractMethod()
        //{
        //    Console.WriteLine("Dog abstact method");
        //}

        public override void MyVirtualMethod()
        {
           Console.WriteLine("dog virtual method");
        }


    }
}
