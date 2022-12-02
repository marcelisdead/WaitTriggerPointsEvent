using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsOnTrigger : MonoBehaviour {

    public UnityEvent OnTriggerEntered;
    public UnityEvent OnTriggerExited;

    public bool checkTag;
    public string tagToCheck;

    private void OnTriggerEnter(Collider other)
    {
        if (checkTag) {
            if (other.gameObject.CompareTag(tagToCheck)) 
            {
                OnTriggerEntered.Invoke();
            }
        }
        else
        {
            OnTriggerEntered.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (checkTag)
        {
            if (other.gameObject.CompareTag(tagToCheck))
            {
                OnTriggerExited.Invoke();
            }
        }
        else
        {
            OnTriggerExited.Invoke();
        }
    }

}
