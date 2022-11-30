using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Need to think about this whole script realization. 
public class UsersBalanceManager : MonoBehaviour 
{
    private static BankAccount _usersBalance;

    public static void AddUsersBalance(int money)
    {
            _usersBalance.balance += money;

        Debug.Log("Users balance has changed!");
    }
    public static int GetUsersBalance()
    {
            if (_usersBalance.balance < 0)
                return 0;
        
            return _usersBalance.balance;
    }
    private void Awake()
    {
        _usersBalance = BankAccount.GetInstance();
    }
}
    
