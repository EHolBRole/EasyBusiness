using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
    public delegate Business DecisionAction(ref Business business);

    public class UniqueDecision : AbstractDecision
    {
        public DecisionAction uniqueDecisionAction;
        public UniqueDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, DecisionAction uniqueDecisionAction, Business.BusinessTier decisionTier)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, decisionTier)
        {
            this.uniqueDecisionAction = uniqueDecisionAction;
        }
    }
}
