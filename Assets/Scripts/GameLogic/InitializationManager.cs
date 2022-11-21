using System.Collections.Generic;
using UnityEngine;
using Libraries;
public class InitializationManager : MonoBehaviour
{

    private void Awake()
    {
        DecisionLib.InitBusinessAvaiableDecisionsLists();
    }
}
