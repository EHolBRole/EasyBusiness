using UnityEngine;

namespace UI
{
    public class BusinessChoiseContinueButton : MonoBehaviour
    {

        public void OnClick()
        {
            Debug.Log("Player chosed his business");

            UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
        }

    }
}