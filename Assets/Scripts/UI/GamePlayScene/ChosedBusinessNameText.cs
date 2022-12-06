using UnityEngine;
using Libraries;
using TMPro;

namespace UI
{
    /// <summary>
    /// Resctruct All UI Text scripts! Try create special class for all text gameObject and then manipulate with list of those GO.
    /// Really good idea. Totally think and totally do.
    /// </summary>
    public class ChosedBusinessNameText : AbstractTextUI
    {
        [SerializeField]
        private TMP_Text _chosedBusinessNameText;

        public override void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
        {
            if (_chosedBusinessNameText.text != UsersBusinessManager.ChoisedBusiness.Name)
                _chosedBusinessNameText.text = UsersBusinessManager.ChoisedBusiness.Name;
            Debug.Log("Name of business _text has been changed.");
        }
    }
}