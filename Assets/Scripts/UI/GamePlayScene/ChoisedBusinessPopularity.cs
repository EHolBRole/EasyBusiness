using UnityEngine;
using TMPro;

public class ChoisedBusinessPopularity : AbstractTextUI
{

    public override void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
    {
        if (_textTMP.text != UsersBusinessManager.ChoisedBusiness.Popularity.ToString())
            _textTMP.text = UsersBusinessManager.ChoisedBusiness.Popularity.ToString();
        // Debug.Log("Popularity of Player's business has been changed.");
    }
}
