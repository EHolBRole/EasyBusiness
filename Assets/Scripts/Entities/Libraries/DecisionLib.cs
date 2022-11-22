using Entities;
using System.Collections.Generic;

namespace Libraries
{
    public static class DecisionLib
    {
        // This is a library for all our Decision Object
        // Could try to create a few examples of Decisions & try to realize feature with auto-adding Decisions to Business lists of 
        // avaiable decisions;
        private static SimpleDecision testDecision = new SimpleDecision("Test name", 50, 10, 3, 50, Business.BusinessTier.BaseTier);
        private static SimpleDecision testDecision2 = new SimpleDecision("Test name 2", 100, -25, 8, 125, Business.BusinessTier.FirstTier);

        public static readonly List<SimpleDecision> allSimpleDecisionsList = new List<SimpleDecision>() { testDecision, testDecision2 };

        public static void InitBusinessAvaiableDecisionsLists()
        {
            foreach (SimpleDecision decision in allSimpleDecisionsList)
            {
                switch (decision.DecisionTier)
                {
                    case Business.BusinessTier.BaseTier:

                        break;
                }
            }
        }

    }
}