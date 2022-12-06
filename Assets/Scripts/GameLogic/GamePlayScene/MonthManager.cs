using UnityEngine;
using Entities;
public class MonthManager : MonoBehaviour
{
    private const int MONTH_LIMIT = 50;

    private int monthCounter;

    private void Start()
    {
        monthCounter = 0;
    }

    public void MoveToNextMonth()
    {
        if (monthCounter < MONTH_LIMIT)
        {
            DecisionManager.DoDecision(UsersBusinessManager.ChoisedBusiness);
            UsersBusinessManager.ChoisedBusiness.ProceedNetworth();
            monthCounter++;
            Debug.Log("New Month begins");
        }
        else
        {
            // Game Over;
        }
    }
}