using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class AbstractTextUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _textTMP;

    public abstract void ChangeText(); 

}
