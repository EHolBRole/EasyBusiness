using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UI
{
    public delegate void UIHandler();

    public class UIController : MonoBehaviour
    {
        public static UIHandler businessUIHandler;
        [SerializeField]
        private ChosedBusinessNameText text;

        public void InitUI()
        {
            businessUIHandler += text.ChangeText;
        }
    }
}