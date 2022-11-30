using UnityEngine;
using Libraries;
using TMPro;

namespace UI
{
    public class ChosedBusinessNameText : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text chosedBusinessNameText;

        public void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
        {
            chosedBusinessNameText.text = UsersBusinessManager.ChoisedBusiness.Name;
            Debug.Log("Name of business text has been changed.");
        }
    }

}