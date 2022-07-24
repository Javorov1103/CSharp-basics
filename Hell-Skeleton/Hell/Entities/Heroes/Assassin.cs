using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Heroes
{
    public class Assassin : AbstractHero
    {
        public Assassin(string name, int strength, int agility, int intelligence, int hitPoints, int damage) : base(name, strength, agility, intelligence, hitPoints, damage)
        {
        }
    }
}
