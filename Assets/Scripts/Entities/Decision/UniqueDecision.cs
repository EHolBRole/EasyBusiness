using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
    public delegate Business UniqueDecisionAction(ref Business business);

    public class UniqueDecision : AbstractDecision
    {
        public UniqueDecisionAction uniqueDecisionAction;
        public UniqueDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, UniqueDecisionAction uniqueDecisionAction, Business.BusinessTier decisionTier)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, decisionTier)
        {
            this.uniqueDecisionAction = uniqueDecisionAction;
        }
    }
}
