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
        if (isFly)
        {
           
            StartCoroutine(FlyMove());
        }

    }


    IEnumerator FlyMove()
    {
        while(isFly)
        {

            Vector3 loc = defectivePackage.transform.position;

            loc.x += hSpeed;

            Debug.Log("RIGHT");
            defectivePackage.transform.position = loc;

            if (activateVert)
            {

               loc.y += vSpeed;

            }

            defectivePackage.transform.position = loc;

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
        if (defectivePackage.transform.position.x > 3f)
        {

            Debug.Log("UP");
            activateVert = true;
            
        }
    }







    
}
