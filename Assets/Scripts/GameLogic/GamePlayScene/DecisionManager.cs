using UnityEngine;
using Entities;
using UI;
using Libraries;
public class DecisionManager : MonoBehaviour
{
    public static bool TryDoDecision(Business business) // Put in Business
    {
        if (UsersBalanceManager.GetUsersBalance() > DecisionLib.choosedDecision.Cost && DecisionLib.choosedDecision.MaxLevel > DecisionLib.choosedDecision.Level)
        {
            UsersBalanceManager.AddUsersBalance((DecisionLib.choosedDecision.Cost) * -1);
            DecisionLib.choosedDecision.ApplyDecision(business);
            return true;
        }
        else
        {
            return false;
        }
    }
}
