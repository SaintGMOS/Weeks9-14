using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TB1 : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float mXS = 1;
    public float mNS = 0;
    public float t;
    // Start is called before the first frame update
    public void IncreaseCall()
    {
        StartCoroutine(Increase());
    }

    // Update is called once per frame
    IEnumerator Increase()
    {
        t = 0;
        Debug.Log("Yes");
        while (t < 1)
        {
            Debug.Log("Yes1");
            t += Time.deltaTime;
            transform.localScale = Vector3.one * mXS * curve.Evaluate(t);
            yield return null;

        }

        


    }
}
