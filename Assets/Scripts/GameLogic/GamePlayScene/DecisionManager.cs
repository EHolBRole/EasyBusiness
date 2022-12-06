using UnityEngine;
using Entities;
using UI;
using Libraries;
public class DecisionManager : MonoBehaviour
{
    private static AbstractDecision _choosedDecision;

    public static void DoDecision(Business business)
    {
        if (UsersBalanceManager.GetUsersBalance() > _choosedDecision.Cost)
        {
            UsersBalanceManager.AddUsersBalance((_choosedDecision.Cost) * -1);
            _choosedDecision.ApplyDecision(business);
        }
    }
}
