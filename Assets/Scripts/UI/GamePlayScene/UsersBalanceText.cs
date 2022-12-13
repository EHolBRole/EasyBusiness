using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UsersBalanceText : AbstractTextUI
{

    [SerializeField]
    private TMP_Text _usersBalanceText;

    public override void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
    {
        _usersBalanceText.text = UsersBalanceManager.GetUsersBalance().ToString();
        Debug.Log("Users balance has been changed.");
        Debug.Log(UsersBalanceManager.GetUsersBalance());
    }
}
