using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UsersBalanceText : MonoBehaviour
{

    [SerializeField]
    private TMP_Text _usersBalanceText;

    public void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
    {
        _usersBalanceText.text = UsersBalanceManager.GetUsersBalance().ToString();
        Debug.Log("Name of business _text has been changed.");
    }

    public void Awake()
    {
        UsersBalanceManager.usersBalanceUIHandler += ChangeText;
    }
}
