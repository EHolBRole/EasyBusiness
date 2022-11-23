using Entities;
using System.Collections.Generic;

namespace Libraries
{
    public static class BusinessLib
    {
        public static Business smallCafe = new Business("Small Cafe", 600, 200, 5, 1000, null, Business.BusinessTier.BaseTier, new List<Business>() { smallSushiRestaraunt, burgerFoodCourt});
        public static Business testBaseBusiness = new Business("Test Base Business", 666, 228, 69, 7777, null, Business.BusinessTier.BaseTier, new List<Business>());
        public static Business smallSushiRestaraunt = new Business("Small Sushi Restaraunt", 5000, 800, 15, 0, null, Business.BusinessTier.FirstTier, new List<Business>());
        public static Business burgerFoodCourt = new Business("Burger Food Court", 2000, 4500, 9, 0, null, Business.BusinessTier.FirstTier, new List<Business>());
        // Create other Cafe-Root businesses

        public static readonly List<Business> baseTierBusinesList = new List<Business>() { smallCafe, testBaseBusiness };
        public static readonly List<Business> firstTierBusinesList = new List<Business>() { smallSushiRestaraunt, burgerFoodCourt};
        public static readonly List<Business> secondTierBusinesList = new List<Business>() { };
        public static readonly List<Business> thirdTierBusinesList = new List<Business>() { };

    }
}