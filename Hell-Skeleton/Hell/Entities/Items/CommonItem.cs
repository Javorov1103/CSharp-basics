using Hell.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Items
{
    public class CommonItem : IItem
    {
        private string name;
        private int strengthBonus;
        private int agilityBonus;
        private int intelligenceBonus;
        private int hitPointsBonus;
        private int damageBonus;

        public CommonItem(string itemName, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus)
        {
            this.name = itemName;
            this.StrengthBonus = strengthBonus;
            this.agilityBonus = agilityBonus;
            this.intelligenceBonus = intelligenceBonus;
            this.hitPointsBonus = hitPointsBonus;
            this.damageBonus = damageBonus;
        }

        public string Name { get { return name; } set { name = value; } }

        public int StrengthBonus { get => strengthBonus; set => strengthBonus = value; }
        public int AgilityBonus { get => agilityBonus; set => agilityBonus = value; }
        public int IntelligenceBonus { get => intelligenceBonus; set => intelligenceBonus = value; }
        public int HitPointsBonus { get => hitPointsBonus; set => hitPointsBonus = value; }
        public int DamageBonus { get => damageBonus; set => damageBonus = value; }
    }
}
