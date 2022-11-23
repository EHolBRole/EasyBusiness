using System.Collections.Generic;
using UnityEngine;
using Libraries;
using Entities;
using TMPro;

public class BusinessChoiseDropdown : MonoBehaviour
{
    private static TMP_Dropdown _dropdown;

    private List<string> _optionList = new List<string>();
    
    private void Awake()
    {
        _dropdown = this.GetComponent<TMP_Dropdown>();

        foreach(Business business in BusinessLib.baseTierBusinesList)
        {
            _optionList.Add(business.Name);
        }

        _dropdown.AddOptions(_optionList);
    }

    public static Business TellChosedBusiness()
    {
        return BusinessLib.baseTierBusinesList[_dropdown.value];
    }

    public void OnValueChange()
    {
        Debug.Log("Choised Business has changed: " + BusinessLib.baseTierBusinesList[_dropdown.value].Name);
    }

}
