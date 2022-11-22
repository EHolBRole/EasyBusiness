using UnityEngine;
using Libraries;

public class InitializationManager : MonoBehaviour
{
    private void Awake()
    {
        ItemInit();
    }

    private void ItemInit()
    {
        DecisionLib.InitBusinessAvaiableDecisionsLists();
        BusinessLib.choisedBusiness = BusinessLib.smallCafe;
    }

}
