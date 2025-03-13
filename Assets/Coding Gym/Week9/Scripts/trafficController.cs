using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trafficController : MonoBehaviour
{
    public RectTransform red;// Image of or UI u want to use
    public RectTransform green;// Image of or UI u want to use
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

    public void m1On()
    { 
            Debug.Log("Works");
            red.localScale = Vector3.one * 2f;

    }


    public void m1Off()
    {
        Debug.Log("Works1");
        red.localScale = (Vector3.one *2) / 2;

    }


    public void m2()
    {
        Debug.Log("Works");
        green.localScale = Vector3.one *1.2f;
    }

    public void m2Off()
    {
        Debug.Log("Works1");
        green.localScale = Vector3.one;
    }

}
