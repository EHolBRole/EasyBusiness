using System.Collections.Generic;
using UnityEngine;
using Libraries;
using Entities;
using TMPro;

public class BusinessChoiseDropdown : MonoBehaviour
{
    public List<string> optionList = new List<string>();
    private void Awake()
    {
        foreach(Business business in BusinessLib.baseTierBusinesList)
        {
            optionList.Add(business.Name);
        }
        this.GetComponent<TMP_Dropdown>().AddOptions(optionList);
    }
    private void FixedUpdate()
    {
        
    }
    public void OnValueChange()
    {
        Debug.Log("Choised Business has changed: " + BusinessLib.baseTierBusinesList[this.GetComponent<TMP_Dropdown>().value].Name);
        BusinessLib.choisedBusiness = BusinessLib.baseTierBusinesList[this.GetComponent<TMP_Dropdown>().value];
    }

}
