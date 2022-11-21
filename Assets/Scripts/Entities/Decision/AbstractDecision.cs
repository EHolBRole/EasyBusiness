using UnityEngine;

namespace Entities
{
    public abstract class AbstractDecision
    {

        public Business.BusinessTier DecisionTier { get; private set; }

        public string Name { get; private set; }

        public int AddedIncome { get; protected set; }
        public int AddedOutlay { get; protected set; }
        public int AddedPopularity { get; protected set; }
        public int Cost 
        { 
            get
            { 
                return Cost * (Level + 1); 
            } 
            protected set 
            { 
            } 
        }
        public int Level { get; protected set; }

        public AbstractDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, Business.BusinessTier decisionTier, int level = 0)
        {
            Name = name;
            AddedIncome = addedIncome;
            AddedOutlay = addedOutlay;
            AddedPopularity = addedPopularity;
            Cost = cost;
            DecisionTier = decisionTier;
            Level = level;
        }

        public void ChangeAllParameters(ref Business business)
        {
            business.ChangeIncome(AddedIncome);
            business.ChangeOutlay(AddedOutlay);
            business.ChangePopularity(AddedPopularity);
            Debug.Log("All parameter changes of the decision was applied!");
        }
        public override string ToString()
        {
            return $"{Name} - Cost: {Cost} | level: {Level}";
        }
    }
}
