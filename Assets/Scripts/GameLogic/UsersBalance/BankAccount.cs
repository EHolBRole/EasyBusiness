using UnityEngine;
public class BankAccount
{
    private static BankAccount _usersBankAccount;

    public int balance;
    // Add new Features or delete this Singleton;

    private BankAccount()
    {
        balance = 0;
    }

    public static BankAccount GetInstance()
    {
        if(_usersBankAccount == null)
            _usersBankAccount = new BankAccount();

        return _usersBankAccount;
    }

}
