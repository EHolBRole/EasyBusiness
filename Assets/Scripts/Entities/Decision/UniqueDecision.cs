using UnityEngine;

namespace Entities
{    

    public class UniqueDecision : AbstractDecision
    {
        public delegate Business DecisionAction(Business business);
        
        private DecisionAction _uniqueDecisionAction;
        public UniqueDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, 
            DecisionAction uniqueDecisionAction, Business.BusinessTier decisionTier, 
            int level = 0, bool isDecisionDone = false)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, decisionTier, level)
        {
            _uniqueDecisionAction = uniqueDecisionAction;
            IsDecisionDone = isDecisionDone;
        }

        public bool IsDecisionDone { get; private set; }

        public override void ApplyDecision(Business business)
        {
            if (IsDecisionDone)
            {
                Debug.Log("Decision already made!");
            }
            base.ApplyDecision(business);
            _uniqueDecisionAction.Invoke(business);
            IsDecisionDone = true;
        }

        public Business DoUniqueDecisionAction(ref Business business) => _uniqueDecisionAction.Invoke(business);

        public override string ToString()
        {
            return $"{Name} - Cost: {Cost} | level: Special";
        }

    }
}
