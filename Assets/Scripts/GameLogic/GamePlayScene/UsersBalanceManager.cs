using UnityEngine;
using Observers;

// Need to think about this whole script realization. 
public class UsersBalanceManager : MonoBehaviour 
{
    private static int _usersBalance;

    [SerializeField]
    private GameObject _usersBalanceTextGO;

    private static AbstractTextUI _usersBalanceTextUI;

    public static void AddUsersBalance(int money)
    {
        _usersBalance += money;

        _usersBalanceTextUI.ChangeText();

        Debug.Log("Users balance has changed!");
    }
    
    public static int GetUsersBalance()
    {
            if (_usersBalance < 0)
                return 0;
        
            return _usersBalance;
    }


    private void Start()
    {
        _usersBalanceTextUI = _usersBalanceTextGO.GetComponent<AbstractTextUI>();

        _usersBalanceTextUI.ChangeText();
    }

    private void Awake()
    {
        _usersBalance = UsersBusinessManager.ChoisedBusiness.StartBalance;
        
    }
}
    
