using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnWait : MonoBehaviour
{
    public float timeToWait;

    public UnityEvent OnTimeComplete;

    public float currentTime;
    public bool waiting = true;

    void Update()
    {
        if (waiting)
        {
            currentTime += Time.deltaTime;

            if(currentTime > timeToWait)
            {
                waiting = false;
                currentTime = 0;
                OnTimeComplete.Invoke();
            }
        }
    }
}
