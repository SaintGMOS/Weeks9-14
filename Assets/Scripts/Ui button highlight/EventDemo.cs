using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    public RectTransform alien;// Image of or UI u want to use
    public UnityEvent OnTimerHasFinished;
    public float timerlength = 3;
    public float t;


    private void Update()
    {
        t += Time.deltaTime;
        if (t > timerlength)
        {

            t = 0;
            OnTimerHasFinished.Invoke(); // INVOKE just means do it or execute things);
        
        }
    }
    public void MouseJustEntered()
    {
        Debug.Log("Mouse Just entered me!");
        alien.localScale = Vector3.one * 1.2f;
    
    
    }

    public void MouseJustLeftImage()
    {
        Debug.Log("Mouse Just left me!");
        alien.localScale = Vector3.one;
    }    
}
