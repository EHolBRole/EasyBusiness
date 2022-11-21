using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
    public class SimpleDecision : AbstractDecision
    {

        public SimpleDecision(string name, int addedIncome, int addedOutlay, int addedPopularity, int cost, Business.BusinessTier decisionTier, int level = 0)
        : base(name, addedIncome, addedOutlay, addedPopularity, cost, decisionTier, level)
        {
            
        }
    }
}