using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Worker : Human
    {
        private decimal wagePerHour;
        private int workedHours;

      
        public Worker(string firstName,string lastName, decimal wagePerHour): base(firstName,lastName)
        {
            this.wagePerHour = wagePerHour;
        }

        public decimal WagePerHour
        {
            get { return wagePerHour; }
            private set { wagePerHour = value; }
        }
        public int WorkedHours
        {
            get { return workedHours; }
            set { workedHours = value; }
        }

        public decimal HowMuchMoneyMadeThisHuman()
        {
            
            return workedHours * wagePerHour;
        }
    }
}
