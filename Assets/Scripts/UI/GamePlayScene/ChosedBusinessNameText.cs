using UnityEngine;
using TMPro;

namespace UI
{
    /// <summary>
    /// Resctruct All UI Text scripts! Try create special class for all text gameObject and then manipulate with list of those GO.
    /// Really good idea. Totally think and totally do.
    /// </summary>
    public class ChosedBusinessNameText : AbstractTextUI
    {

        public override void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
        {
            if (_textTMP.text != UsersBusinessManager.ChoisedBusiness.Name)
                _textTMP.text = "UsersBusinessManager.ChoisedBusiness.Name: " + UsersBusinessManager.ChoisedBusiness.Name;
            // Debug.Log("Name of Player's business has been changed.");
        }
    }
}