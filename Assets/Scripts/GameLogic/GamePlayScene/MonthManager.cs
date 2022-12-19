using UnityEngine;
using Entities;
using Observers;
public class MonthManager : MonoBehaviour
{
    private const int MONTH_LIMIT = 36;

    [SerializeField]
    private GameObject _monthNumTextGO;

    [SerializeField]
    private GameObject _businessTextPublisherGO;

    private static BusinessTextPublisher _businessTextPublisher;

    private AbstractTextUI _monthNumTextUI;

    public static int MonthCounter { get; private set; }

    private void Start()
    {
        MonthCounter = 1;

        _monthNumTextUI = _monthNumTextGO.GetComponent<AbstractTextUI>();

        _businessTextPublisher = _businessTextPublisherGO.GetComponent<BusinessTextPublisher>();

        _monthNumTextUI.ChangeText();
    }

    public bool TryMoveToNextMonth()
    {
        if (MonthCounter > MONTH_LIMIT)
        {
            // game over
            Debug.Log("GAME OVER");
        }

        if (DecisionManager.TryDoDecision(UsersBusinessManager.ChoisedBusiness))
        {
            Debug.Log("Change Balance");
            UsersBalanceManager.AddUsersBalance(UsersBusinessManager.ChoisedBusiness.ProceedNetworth());
            MonthCounter++;
            _monthNumTextUI.ChangeText();
            _businessTextPublisher.NotifyObservers();
            Debug.Log("New Month begins");
            return true;
        }
        else
        {
            Debug.Log("Sorry, you can't apply this decision!");
            return false;
        }
    }
}
