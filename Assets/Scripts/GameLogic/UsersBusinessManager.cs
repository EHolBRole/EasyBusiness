using UnityEngine;
using UI;
using Entities;
public class UsersBusinessManager : MonoBehaviour
{
    private static Business _choisedBusiness;

    public static Business ChoisedBusiness
    { 
        get
        {
            return _choisedBusiness;
        }
        set
        { 
            _choisedBusiness = value;
            UIController.businessUIHandler.Invoke();
        } 
    }

    private void Awake()
    {
        ChoisedBusiness = BusinessChoiseDropdown.TellChosedBusiness();
    }

}
