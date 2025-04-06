using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Defective : MonoBehaviour
{
    public bool isDefective;  // Flag to indicate if this package is defective

    public GameObject defectiveIndicator; // Ref to a visual that shows the package is defective

    public GameObject PushButton; // Ref to a push button GameObject

    public ParticleSystem explosion;  // Ref to the particle system used for the explosion effect


    // Diff Classs
    public bool fly; // Determines if the package should fly 

    public FlyAway flyClass; // Ref to the FlyAway that handles flying movement

    public UnityEvent Explosion; // UnityEvent to handle explosion events

    // Method to start the explosion effect
    public void startExplosion()
    {
        //Debug.Log("Explosion");
        // Activate the explosion particle system GameObject
        explosion.gameObject.SetActive(true);
    }



    // Method to set if this package is defective or not
    public void SetDefective(bool defectiveValue)
    {
        // Update the defective flag
        isDefective = defectiveValue;

        // If the package is defective, execute the following 
        if (isDefective)
        {
            //Debug.Log("SECOND: " + isDefective);
            //Debug.Log("DEFECTIVE!!!!!!!!");

            // Activate the defective indicator
            defectiveIndicator.SetActive(true);

            // Invoke the Explosion event 
            Explosion.Invoke();

            // Add the startExplosion method as a listener to the Explosion event.
            Explosion.AddListener(startExplosion);

            // Activate flying based on the fly flag
            flyClass.SetFly(fly);

            // Disable the push button
            PushButton.gameObject.SetActive(false);


        }
        else
        {
            //Debug.Log("Normal");
  
        }


    }

   






    }
