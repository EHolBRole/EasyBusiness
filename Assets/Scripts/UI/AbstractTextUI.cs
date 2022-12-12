using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class AbstractTextUI : MonoBehaviour // Think, maybe Interface
{
    [SerializeField]
    protected TMP_Text _textTMP;

    public abstract void ChangeText(); 

    public string GetText()
    {
        return _textTMP.text;
    }

}
