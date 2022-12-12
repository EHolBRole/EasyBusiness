using UnityEngine;
using TMPro;

public class ChosedBusinessIncome : AbstractTextUI
{

    public override void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
    {
        if (_textTMP.text != UsersBusinessManager.ChoisedBusiness.Income.ToString())
            _textTMP.text = UsersBusinessManager.ChoisedBusiness.Income.ToString();
        Debug.Log("Income of Player's business has been changed.");
    }
}
