using System.Collections.Generic;
using UnityEngine;
using Entities;
using Libraries;
using TMPro;

public class AllDecisionDropDown : MonoBehaviour
{
    private static TMP_Dropdown _dropdown;

    [SerializeField]
    private TMP_Text _text;

    private List<string> _optionList = new List<string>();

    private void Start()
    {
        _dropdown = this.GetComponent<TMP_Dropdown>();

        foreach(AbstractDecision decision in BusinessLib.choisedBusiness.GetAvaiableDecisionList())
        {
            _optionList.Add(decision.Name);
        }

        _dropdown.AddOptions(_optionList);

        DecisionLib.choosedDecision = BusinessLib.choisedBusiness.GetAvaiableDecisionList()[_dropdown.value];
        _text.text = DecisionLib.choosedDecision.ToString();
    }

    public void OnEnable()
    {
        _text.text = DecisionLib.choosedDecision.ToString();
    }
    public void OnValueChange()
    {
        Debug.Log("Choised Decision has changed: " + BusinessLib.choisedBusiness.GetAvaiableDecisionList()[_dropdown.value].Name);
        DecisionLib.choosedDecision = BusinessLib.choisedBusiness.GetAvaiableDecisionList()[_dropdown.value];
        _text.text = DecisionLib.choosedDecision.ToString();
    }
}
