using UnityEngine;
using TMPro;

public class ChosedBusinessOutlay : AbstractTextUI
{

    public override void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
    {
        if (_textTMP.text != UsersBusinessManager.ChoisedBusiness.Outlay.ToString())
            _textTMP.text = 
            "Outlay: "+UsersBusinessManager.ChoisedBusiness.Outlay.ToString();
        // Debug.Log("Outlay of Player's business has been changed.");
    }
}
