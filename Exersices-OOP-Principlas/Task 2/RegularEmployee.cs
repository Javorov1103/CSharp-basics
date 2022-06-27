using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class RegularEmployee : Worker
    {
        public RegularEmployee(string firstName, string lastName, decimal wagePerHour) : base(firstName, lastName, wagePerHour)
        {
        }
    }
}
