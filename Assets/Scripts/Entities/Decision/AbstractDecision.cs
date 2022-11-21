using UnityEngine;

namespace Entities
{
    public abstract class AbstractDecision
    {
        private Business.BusinessTier _decisionTier;

        public string Name { get; private set; }

        public int AddedIncome { get; protected set; }
        public int AddedOutlay { get; protected set; }
        public int AddedPopularity { get; protected set; }
        public int Cost { get; protected set; }

        public AbstractDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, Business.BusinessTier decisionTier)
        {
            Name = name;
            AddedIncome = addedIncome;
            AddedOutlay = addedOutlay;
            AddedPopularity = addedPopularity;
            Cost = cost;
            _decisionTier = decisionTier;
        }

        public override string ToString()
        {
            return $"{Name} - Cost: {Cost}";
        }
    }
}
