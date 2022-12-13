namespace Entities
{
    public class SimpleDecision : AbstractDecision
    {
        public SimpleDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, 
            Business.BusinessTier decisionTier, int level = 0, int maxLevel = 5)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, decisionTier, level, maxLevel)
        {
            
        }

        public override int Cost { get => base.Cost * (Level + 1); protected set => base.Cost = value; }

        public override string ToString()
        {
            if(Level == -1) {
                return "Skip this month!";
            } else {
                if(Level == MaxLevel) {
                    return "This Decision have max level upgrade, choose another one!";
                } else {
                    return $"{Name} - Cost: {Cost} | level: {Level}";
                }                
            }
        }

    }
}