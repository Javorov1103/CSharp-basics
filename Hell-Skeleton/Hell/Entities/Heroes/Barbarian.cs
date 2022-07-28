public class Barbarian : AbstractHero
{
   

    public Barbarian(string name)
        : base(name, Constants.BarbarianStrengthConst, Constants.BarbarianAgilityConst, Constants.BarbarianIntelligenceConst, Constants.BarbarianHitPointsConst, Constants.BarbarianDamageConst)
    {
    }
}