namespace Entities
{
    public class SimpleDecision : AbstractDecision
    {
        public SimpleDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, int level = 0, int maxLevel = 5)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, level, maxLevel)
        {
            
        }

        public override int Cost { get => base.Cost * (Level + 1); protected set => base.Cost = value; }

        public override string ToString()
        {
            if(this.Level == -1)
                return "Skip this month!";
            
            if(this.Level >= this.MaxLevel) 
                return "This Decision have max level upgrade, choose another one!"; 

            return $"{this.Name} - Cost: {this.Cost} | level: {this.Level}";            
        }

    }
}