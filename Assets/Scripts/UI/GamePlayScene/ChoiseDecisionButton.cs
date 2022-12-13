using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiseDecisionButton : MonoBehaviour
{
    [SerializeField]
    private GameObject GamePlayPanelGO;
    [SerializeField]
    private GameObject ChoiseDecisionPanelGO;

    public void OnClick()
    {
        GamePlayPanelGO.SetActive(false);
        ChoiseDecisionPanelGO.SetActive(true);
    }
}
