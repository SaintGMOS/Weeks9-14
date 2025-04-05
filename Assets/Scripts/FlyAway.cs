using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAway : MonoBehaviour
{
    public bool isFly;
    public float flySpeed;
        
    public GameObject defectivePackage;


    public void SetFly(bool fly)
    {

        isFly = fly;

    }


    IEnumerator FlyMove()
    {
        if (isFly)
        {
            Vector3 loc = transform.position;

            loc.x += flySpeed;

            defectivePackage.transform.position = loc;

        }
        yield return null;


    }





    // Start is called before the first frame update
    void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            StartCoroutine(FlyMove());
        }







    
}
