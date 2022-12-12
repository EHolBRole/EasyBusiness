using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observers 
{
    public class BusinessTextPublisher : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _BusinessTextObserversGO = new List<GameObject>(); // Maybe use tags to init
            
        private List<AbstractTextUI> _businessTextObservers = new List<AbstractTextUI>();    
        
        //public void AddObserver(GameObject obs)
        //{
        //    _BusinessTextObserversGO.Add(obs);
        //}

        //public void RemoveObserver(GameObject obs)
        //{
        //    _BusinessTextObserversGO.Remove(obs);
        //}

        public void NotifyObservers()
        {
            foreach (AbstractTextUI abstractText in _businessTextObservers)
            {
                abstractText.ChangeText();
                Debug.Log(abstractText.GetText());
            }
        }

        public void Awake()
        {
           foreach (GameObject observer in _BusinessTextObserversGO)
            {
                AbstractTextUI abstractText = observer.GetComponent<AbstractTextUI>();
                _businessTextObservers.Add(abstractText);
            }
        }
    }

}