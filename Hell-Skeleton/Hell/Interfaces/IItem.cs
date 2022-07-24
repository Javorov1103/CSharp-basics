using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Interfaces
{
    public interface IItem
    {
        int StrengthBonus { get; }
        int AgilityBonus { get; }
        int IntelligenceBonus { get; }
        int HitPointsBonus { get; }
        int DamageBonus { get; }
        string Name { get; }
    }
}
