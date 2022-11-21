using UnityEngine;
using Libraries;

public class InitializationManager : MonoBehaviour
{
    private void Awake()
    {
        DecisionLib.InitBusinessAvaiableDecisionsLists();
    }

    private void Start()
    {
        BusinessLib.choisedBusiness = BusinessLib.smallCafe;
    }

}
