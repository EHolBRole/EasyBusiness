using UnityEngine;
using UI;
using Entities;
public class UsersBusinessManager : MonoBehaviour
{
    private static Business _choisedBusiness; // add factory to create businesses;

    public static UIHandler businessUIHandler;
    public static Business ChoisedBusiness
    { 
        get
        {
            return _choisedBusiness;
        }
        set
        { 
            _choisedBusiness = value;
            businessUIHandler.Invoke();
        } 
    }

    private void Awake()
    {
        ChoisedBusiness = BusinessChoiseDropdown.TellChosedBusiness();
    }

}
