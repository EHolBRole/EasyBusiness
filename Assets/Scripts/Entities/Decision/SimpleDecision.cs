namespace Entities
{
    public class SimpleDecision : AbstractDecision
    {
        public SimpleDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, 
            Business.BusinessTier decisionTier, int level = 0)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, decisionTier, level)
        {
            
        }

        public override int Cost { get => base.Cost * (Level + 1); protected set => base.Cost = value; }

        public override string ToString()
        {
            return $"{Name} - Cost: {Cost} | level: {Level}";
        }

    }
}