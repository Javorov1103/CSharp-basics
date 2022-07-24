using Hell.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Items
{
    public class RecipeItem : IRecipe
    {
        private string name;
        private IList<string> requiredItems;

        public IList<string> RequiredItems
        {
            get { return requiredItems; }
            set { requiredItems = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int StrengthBonus => throw new NotImplementedException();

        public int AgilityBonus => throw new NotImplementedException();

        public int IntelligenceBonus => throw new NotImplementedException();

        public int HitPointsBonus => throw new NotImplementedException();

        public int DamageBonus => throw new NotImplementedException();
    }
}
