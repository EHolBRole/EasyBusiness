using System.Collections.Generic;
using UnityEngine;
using Libraries;
using Entities;
using TMPro;

namespace UI
{
    public class BusinessChoiseDropdown : MonoBehaviour
    {
        private static TMP_Dropdown _dropdown;

        private List<string> _optionList = new List<string>();

        private void Start()
        {
            _dropdown = this.GetComponent<TMP_Dropdown>();

            foreach (Business business in BusinessLib.baseTierBusinesList)
            {
                _optionList.Add(business.Name);
            }

            _dropdown.AddOptions(_optionList);
        }

        public static Business TellChosedBusiness() => BusinessLib.baseTierBusinesList[_dropdown.value];

        public void OnValueChange()
        {
            Debug.Log("Choised Business has changed: " + BusinessLib.baseTierBusinesList[_dropdown.value].Name);
        }

    }
}