using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mover : MonoBehaviour
{

    // Reference to a prefab 
    public GameObject prefab;

    // Speed at which the object will move along the x
    public float speed = 0.1f;

    // Flag to determine whether the object should start moving
    private bool startMove = false;

    // Reference to the Spawner that does the PackageSpawned event
    public Spawner spawner;

   



    void Start()
    {
        // Check if the spawner reference is assigned
        if (spawner != null)
        {
            //Debug.Log("StartMOVEMENT");
            // Subscribe the StartMoving method to the spawner's PackageSpawned event
            spawner.PackageSpawned.AddListener(StartMoving);

        }
    }




    // Update is called once per frame
    void Update()
    {
        // If startMove is true, update the position of the object
        if (startMove)
        {

            // Get the current position
            Vector3 loc = transform.position;
            // Increment the x position by speed
            loc.x += speed;
            // Apply the new position
            transform.position = loc;

        }


    }




    // This method is called when the PackageSpawned event is invoked
    public void StartMoving()
    {

        // Set startMove to true to begin moving the object 
        startMove = true;
        
    }

}
