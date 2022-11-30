using UnityEngine;

namespace UI
{
    public class BusinessChoiseContinueButton : MonoBehaviour
    {
        [SerializeField]
        private GameObject _businessChoisePanelGO;
        [SerializeField]
        private GameObject _gameplayPanelGO;
        public void OnClick()
        {
            _gameplayPanelGO.SetActive(true);
            _businessChoisePanelGO.SetActive(false);
            Debug.Log("Player chosed his business");
        }

    }
}