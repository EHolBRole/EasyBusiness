using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Need to think about this whole script realization. 
public class UsersBalanceManager : MonoBehaviour
{
    private BankAccount _usersBalance;

    private void Awake()
    {
        _usersBalance = BankAccount.GetInstance();
    }

    public void ChangeUsersBalance(int money)
    {
        _usersBalance.balance += money;

        Debug.Log("Users balance has changed!");
    }

    public int GetUsersBalance()
    {
        if (_usersBalance.balance < 0)
            return 0;
        
        return _usersBalance.balance;
    }
}
