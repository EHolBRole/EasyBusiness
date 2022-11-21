using Entities;
using System.Collections.Generic;

namespace Libraries
{
    static class DecisionLib
    {
        // This is a library for all our Decision Object
        // Could try to create a few examples of Decisions & try to realize feature with auto-adding Decisions to Business lists of 
        // avaiable decisions;

        public static SimpleDecision testDecision = new SimpleDecision("Test name", 50, 10, 3, 50, Business.BusinessTier.BaseTier);
        public static SimpleDecision testDecision2 = new SimpleDecision("Test name 2", 100, -25, 8, 125, Business.BusinessTier.FirstTier);

        public static List<AbstractDecision> allSimpleDecisionsList = new List<AbstractDecision>() { testDecision };

        public static void InitBusinessAvaiableDecisionsLists()
        {
            foreach (Business business in BusinessLib.allBusinessList)
            {
                foreach(SimpleDecision decision in allSimpleDecisionsList)
                {
                    if (decision.DecisionTier == business.Tier)
                    {
                        business.AddNewDecisionToAvaiableDecisionsList(decision);
                    }
                }
            }
        }
    }
}