using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAway : MonoBehaviour
{
    public bool isFly;
    public float hSpeed;
    public float vSpeed;

    public bool activateVert = false;

    public GameObject defectivePackage;


    public void SetFly(bool fly)
    {

        isFly = fly;
        Debug.Log("FLYDAMMIT!");
        Debug.Log("THIRD: " + isFly);
        if (isFly)
        {
            Debug.Log("Starting Coroutine");
            StartCoroutine(FlyMove());
            
        }

    }


    IEnumerator FlyMove()
    {
        while(isFly)
        {

            Vector3 loc = defectivePackage.transform.position;

            loc.x += hSpeed * Time.deltaTime;

            Debug.Log("RIGHT" + loc.x);
            
            if (activateVert)
            {
                
                loc.y += vSpeed * Time.deltaTime;
                Debug.Log("UP" + loc.y);

            }

            defectivePackage.transform.position = loc;
            Debug.Log("New position: " + loc);

            yield return null;

        }
    }



    // Start is called before the first frame update
    void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
        if (defectivePackage.transform.position.x > -8f)
        {

        
            activateVert = true;
            
        }
    }







    
}
