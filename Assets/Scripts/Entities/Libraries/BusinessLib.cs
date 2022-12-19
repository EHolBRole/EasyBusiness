using Entities;
using System.Collections.Generic;

namespace Libraries
{
    // add Fabrics
    public static class BusinessLib
    {
        public static Business choisedBusiness = new Business("", 0, 0, 0, 0, null,new List<AbstractDecision>());

        public static Business smallCafe = new Business("Small Cafe", 600, 200, 5, 1000, null, DecisionLib.allSimpleDecisionsList);
        public static Business testBaseBusiness = new Business("Test business", 666, 333, 77, 999, null, DecisionLib.allSimpleDecisionsList);
        // Create other Cafe-Root businesses

        // Think about lists of business Tiers;
        public static readonly List<Business> baseTierBusinesList = new List<Business>() { smallCafe, testBaseBusiness };
    }
}