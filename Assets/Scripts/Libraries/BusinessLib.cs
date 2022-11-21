using Entities;

namespace Libraries
{
    static class BusinessLib
    {
        public static Business smallCafe = new Business("Small Cafe", 600, 200, 5, 100, null, Business.BusinessTier.BaseTier, null);
        public static Business smallSushiRestaraunt = new Business("Small Sushi Restaraunt", 5000, 800, 15, 100, null, Business.BusinessTier.FirstTier, null); 
        // Create other Cafe-Root businesses
    }
}