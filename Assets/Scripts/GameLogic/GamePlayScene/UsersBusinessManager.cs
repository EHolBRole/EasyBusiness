using UnityEngine;
using Observers;
using Entities;
using Libraries;
public class UsersBusinessManager : MonoBehaviour
{// add factory to create businesses;

    [SerializeField]
    private GameObject _BusinessTextPublisherGO;

    private static BusinessTextPublisher _businessTextPublisher;
    
    
    public void Start()
    {
        _businessTextPublisher = _BusinessTextPublisherGO.GetComponent<BusinessTextPublisher>();

        _businessTextPublisher.NotifyObservers();
    }

    public static Business ChoisedBusiness
    { 
        get
        {
            return BusinessLib.choisedBusiness;
        }
        set
        {
            BusinessLib.choisedBusiness = value;

            _businessTextPublisher.NotifyObservers();
        }
    }
}
