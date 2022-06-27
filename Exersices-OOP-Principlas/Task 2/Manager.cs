using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Manager : Worker
    {
        public Manager(string firstName, string lastName, decimal wagePerHour) : base(firstName, lastName, wagePerHour)
        {
        }
    }
}
