using UnityEngine;
using UI;

// Need to think about this whole script realization. 
public class UsersBalanceManager : MonoBehaviour 
{
    private static int _usersBalance;

    public static UIHandler usersBalanceUIHandler; // consider to re-write as event;
    
    public static void AddUsersBalance(int money)
    {
        _usersBalance += money;

        usersBalanceUIHandler.Invoke();

        Debug.Log("Users balance has changed!");
    }
    
    public static int GetUsersBalance()
    {
            if (_usersBalance < 0)
                return 0;
        
            return _usersBalance;
    }

    private void Awake()
    {
        _usersBalance = UsersBusinessManager.ChoisedBusiness.StartBalance;
        Debug.Log("Start Balance Initialized");
        // usersBalanceUIHandler.Invoke();
    }
}
    
