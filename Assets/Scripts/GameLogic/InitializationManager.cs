using UnityEngine;
using Libraries;
using UI;

public class InitializationManager : MonoBehaviour
{
    // Delegate to different classes to initializate every separate scene.
    private void Awake()
    {
        ItemInit();
    }

    private void ItemInit()
    {
        // DecisionLib.InitBusinessAvaiableDecisionsLists();
    }

}
