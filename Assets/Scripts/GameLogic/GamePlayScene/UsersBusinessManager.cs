using System.Collections.Generic;
using UnityEngine;
using Observers;
using Entities;
public class UsersBusinessManager : MonoBehaviour
{
    private static Business _choisedBusiness = new Business("", 0, 0, 0, 0, null, Business.BusinessTier.BaseTier, new List<Business>()); // add factory to create businesses;

    [SerializeField]
    private GameObject _BusinessTextPublisherGO;

    private ObservableForBusinessText _businessTextPublisher;
    
    public void Start()
    {
        _businessTextPublisher = _BusinessTextPublisherGO.GetComponent<ObservableForBusinessText>();
    }

    public static Business ChoisedBusiness
    { 
        get
        {
            return _choisedBusiness;
        }
        set
        { 
            _choisedBusiness = value;
        } 
    }
}
