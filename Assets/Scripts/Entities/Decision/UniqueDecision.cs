using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
    public delegate Business DecisionAction(ref Business business);

    public class UniqueDecision : AbstractDecision
    {
        private DecisionAction _uniqueDecisionAction;

        public bool IsDecisionDone { get; private set; }
        public UniqueDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, DecisionAction uniqueDecisionAction, Business.BusinessTier decisionTier, int level = 0, bool isDecisionDone = false)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, decisionTier, level)
        {
            _uniqueDecisionAction = uniqueDecisionAction;
            IsDecisionDone = isDecisionDone;
        }

        public override void DoDecision(ref Business business)
        {
            if (IsDecisionDone)
            {
                Debug.Log("Sorry, you already've made this decision!");
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
