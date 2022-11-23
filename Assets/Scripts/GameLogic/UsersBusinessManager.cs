using UnityEngine;
using Entities;
public class UsersBusinessManager : MonoBehaviour
{
    public static Business choisedBusiness;

    private void Awake()
    {
        choisedBusiness = BusinessChoiseDropdown.TellChosedBusiness();
    }

}
