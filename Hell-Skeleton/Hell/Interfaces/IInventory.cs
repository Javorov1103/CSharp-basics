using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Interfaces
{
    public interface IInventory
    {
        long TotalStrengthBonus { get; }
        long TotalAgilityBonus { get; }
        long TotalIntelligenceBonus { get; }
        long TotalHitPointsBonus { get; }
        long TotalDamageBonus { get; }

        void AddRecipeItem(IRecipe recipe);
    }
}
