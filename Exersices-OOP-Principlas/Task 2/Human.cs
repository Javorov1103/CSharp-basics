using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public abstract class Human
    {
        private string firstName;

        private string lastName;

       
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get 
            { 
                return firstName;
            }
            
        }

        public string LastName
        {
            get { return lastName; }
           
        }
    }
}
