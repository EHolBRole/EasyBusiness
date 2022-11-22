using Entities;
using System.Collections.Generic;

namespace Libraries
{
    public static class BusinessLib
    {
        public static Business choisedBusiness;

        public static Business smallCafe = new Business("Small Cafe", 600, 200, 5, 1000, null, Business.BusinessTier.BaseTier);
        public static Business smallSushiRestaraunt = new Business("Small Sushi Restaraunt", 5000, 800, 15, 0, null, Business.BusinessTier.FirstTier);
        public static Business burgerFoodCourt = new Business("Burger Food Court", 2000, 4500, 9, 0, null, Business.BusinessTier.FirstTier);
        // Create other Cafe-Root businesses

        public static List<Business> baseTierBusinesList = new List<Business>() { smallCafe };
        public static List<Business> firstTierBusinesList = new List<Business>() { smallSushiRestaraunt, burgerFoodCourt};
        public static List<Business> secondTierBusinesList = new List<Business>() { };
        public static List<Business> thirdTierBusinesList = new List<Business>() { };

        public static void InitBusinessAvaiableDecisionsLists()
        {
            foreach (Business business in BusinessLib.baseTierBusinesList) // Think about algorythm. Too inefficient. 
            {
                foreach (SimpleDecision decision in DecisionLib.allSimpleDecisionsList)
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