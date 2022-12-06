using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observers 
{
    public class ObservableForBusinessText : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _BusinessTextObserversGO = new List<GameObject>();
        
        private List<AbstractTextUI> businessTextObservers = new List<AbstractTextUI>();
        
        public void AddObserver(GameObject obs)
        {
            _BusinessTextObserversGO.Add(obs);
        }

        public void RemoveObserver(GameObject obs)
        {
            _BusinessTextObserversGO.Remove(obs);
        }

        public void NotifyObservers()
        {
            foreach (AbstractTextUI abstractText in businessTextObservers)
            {
                abstractText.ChangeText();
            }
        }

        public void Awake()
        {
           foreach (GameObject observer in _BusinessTextObserversGO)
            {
                AbstractTextUI abstractText = observer.GetComponent<AbstractTextUI>();
                businessTextObservers.Add(abstractText);
                Debug.Log(abstractText.ToString());
            }
        }
    }

}