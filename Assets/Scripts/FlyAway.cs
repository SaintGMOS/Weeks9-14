using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAway : MonoBehaviour
{

    
    public bool isFly;  // Flag  whether the package should fly

    // Horizontal and vertical speeds for movement 
    public float hSpeed;
    public float vSpeed;

    // When set to true, vertical movementis activated
    public bool activateVert = false;

    // Reference to the GameObject that should be moved 
    public GameObject defectivePackage;

    // Method to set whether the object should fly or not
    public void SetFly(bool fly)
    {

        // Update the isFly 
        isFly = fly;

        //Debug.Log("FLYDAMMIT!");

        // If the flag is true, start the coroutine to handle movement
        if (isFly)
        {

            //Debug.Log("Starting Coroutine");
            StartCoroutine(FlyMove());
            
        }

    }
    // Coroutine that updates the package's position each frame while isFly remains true
    IEnumerator FlyMove()
    {

        // Continue looping as long as isFly is true
        while (isFly)
        {
            // Get the current position of the defective package
            Vector3 loc = defectivePackage.transform.position;
            
            // Update the X location
            loc.x += hSpeed * Time.deltaTime;

            //Debug.Log("RIGHT" + loc.x);

            // If vertical movement is activated, increment the y position
            if (activateVert)
            {
                
                loc.y += vSpeed * Time.deltaTime;
               //Debug.Log("UP" + loc.y);

            }

            // Update the package's position with the new osition
            defectivePackage.transform.position = loc;

            //Debug.Log("New position: " + loc);

            yield return null;

        }
    }



        // Update is called once per frame
        void Update()
        {


        // Check if the package's x position has passed (-8f)
        // When it does, activate vertical movement by setting activateVert to true
        if (defectivePackage.transform.position.x > -8f)
        {

            activateVert = true;
            
        }
    }







    
}
