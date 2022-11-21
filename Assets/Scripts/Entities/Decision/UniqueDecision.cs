using UnityEngine;

namespace Entities
{
    public delegate Business DecisionAction(ref Business business);

    public class UniqueDecision : AbstractDecision
    {
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

        public override void DoDecision(ref Business business)
        {
            if (IsDecisionDone)
            {
                Debug.Log("Decision already made!");
            }
            base.DoDecision(ref business);
            _uniqueDecisionAction.Invoke(ref business);
            IsDecisionDone = true;
        }

        public Business DoUniqueDecisionAction(ref Business business) => _uniqueDecisionAction.Invoke(ref business);

        public override string ToString()
        {
            return $"{Name} - Cost: {Cost} | level: Special";
        }

    }
}
