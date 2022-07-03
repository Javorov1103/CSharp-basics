using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Student : Human, IComparable
    {
        private double mark;


        public Student(string firstName, string lastName, double mark)
            : base(firstName, lastName)
        {
            this.mark = mark;
        }

        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public int CompareTo(object obj)
        {
           
            Student otherStudent = (Student)obj;

            if (mark < otherStudent.mark)
            {
                return -1;
            }
            else if (mark > otherStudent.mark)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Mark}";
        }
    }
}
