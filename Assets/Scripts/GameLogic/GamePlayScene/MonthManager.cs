using UnityEngine;
using Entities;
public class MonthManager : MonoBehaviour
{
    private const int MONTH_LIMIT = 60;

    [SerializeField]
    private GameObject _monthNumTextGO;

    private AbstractTextUI _monthNumTextUI;

    public static int MonthCounter { get; private set; }

    private void Start()
    {
        MonthCounter = 1;

        _monthNumTextUI = _monthNumTextGO.GetComponent<AbstractTextUI>();

        _monthNumTextUI.ChangeText();
    }

    public void MoveToNextMonth()
    {
        if (MonthCounter < MONTH_LIMIT)
        {
            DecisionManager.DoDecision(UsersBusinessManager.ChoisedBusiness);
            UsersBusinessManager.ChoisedBusiness.ProceedNetworth();
            MonthCounter++;
            _monthNumTextUI.ChangeText();
            Debug.Log("New Month begins");
        }
        else
        {
            // Game Over;
        }
    }
}
