using UnityEngine;
using Libraries;
using TMPro;

public class BusinessChoiseDropdown : MonoBehaviour
{

    public void OnValueChange()
    {
        Debug.Log("Choised Business has changed: " + BusinessLib.allBusinessList[this.GetComponent<TMP_Dropdown>().value].Name);
        BusinessLib.choisedBusiness = BusinessLib.allBusinessList[this.GetComponent<TMP_Dropdown>().value];
    }

}
