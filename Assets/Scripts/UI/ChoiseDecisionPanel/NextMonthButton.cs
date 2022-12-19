using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMonthButton : MonoBehaviour
{
    [SerializeField]
    private GameObject GamePlayPanelGO;
    [SerializeField]
    private GameObject ChoiseDecisionPanelGO;

    private MonthManager monthManager;

    public void Start()
    {
        monthManager = GamePlayPanelGO.GetComponent<MonthManager>();
    }
    public void OnClick()
    {
        if(monthManager.TryMoveToNextMonth())
        {
            ChoiseDecisionPanelGO.SetActive(false);
            GamePlayPanelGO.SetActive(true);
        }
    }
}
