using UnityEngine;
using Libraries;
using TMPro;

public class ChosedBusinessNameText : MonoBehaviour
{
    [SerializeField]
    private TMP_Text chosedBusinessNameText;
    private void FixedUpdate()
    {
        chosedBusinessNameText.text = BusinessLib.choisedBusiness.Name;
    }

}
