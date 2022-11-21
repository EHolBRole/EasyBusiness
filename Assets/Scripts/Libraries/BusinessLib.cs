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

        public static List<Business> allBusinessList = new List<Business>() { smallCafe, smallSushiRestaraunt, burgerFoodCourt};

    }
}