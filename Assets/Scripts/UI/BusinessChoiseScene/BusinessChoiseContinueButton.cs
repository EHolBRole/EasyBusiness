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
            UsersBusinessManager.ChoisedBusiness = BusinessChoiseDropdown.TellChosedBusiness();
            Debug.Log("Player chosed his business");

            UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
        }

    }
}