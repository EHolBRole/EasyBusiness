using UnityEngine;
using Libraries;
using UI;

public class InitializationManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameplayPanelGO;

    private UIController _uicontroller;
    private void Awake()
    {
        _uicontroller = gameplayPanelGO.GetComponent<UIController>();
        ItemInit();
        _uicontroller.InitUI();
    }

    private void ItemInit()
    {
        // DecisionLib.InitBusinessAvaiableDecisionsLists();
    }

}
