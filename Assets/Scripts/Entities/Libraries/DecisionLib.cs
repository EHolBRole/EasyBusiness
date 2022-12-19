using Entities;
using System.Collections.Generic;

namespace Libraries
{
    public static class DecisionLib
    {
        // Reconstruct to add Fabrics to code

        // This is a library for all our Decision Object
        // Could try to create a few examples of Decisions & try to realize feature with auto-adding Decisions to Business lists of 
        // avaiable decisions;
        public static AbstractDecision choosedDecision = new SimpleDecision("none", 0, 0, 0, 0);
        
        public static AbstractDecision skipDecision = new SimpleDecision("Skip", 0, 0, 0, 0);

        private static SimpleDecision testDecision = new SimpleDecision("Test name", 50, 10, 3, 50);
        private static SimpleDecision testDecision2 = new SimpleDecision("Test name 2", 100, -25, 8, 125);

        public static readonly List<AbstractDecision> allSimpleDecisionsList = new List<AbstractDecision>() { skipDecision, testDecision, testDecision2 };

        //public static void InitBusinessAvaiableDecisionsLists()
        //{
        //    foreach (SimpleDecision decision in allSimpleDecisionsList)
        //    {
        //        switch (decision.DecisionTier)
        //        {
        //            case Business.BusinessTier.BaseTier:

        //                break;
        //        }
        //    }
        //}

    }
}