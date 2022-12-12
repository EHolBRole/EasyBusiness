using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonthNumText : AbstractTextUI
{

    public override void ChangeText() // Think about realization. Totaly shouldn't be put in every Frame proceding. 
    {
        _textTMP.text = MonthManager.MonthCounter.ToString();
        Debug.Log("Month number has been changed.");
    }
}
