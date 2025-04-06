using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Defective : MonoBehaviour
{
    public bool isDefective;

    public GameObject defectiveIndicator;

    public GameObject created;

    public GameObject PushButton;

    public ParticleSystem explosion;


    // Diff Classs
    public bool fly;

    public FlyAway flyClass;

    public UnityEvent Explosion;

    public void startExplosion()
    {
        Debug.Log("Explosion");
        explosion.gameObject.SetActive(true);
    }




    public void SetDefective(bool defectiveValue)
    {

        isDefective = defectiveValue;

        if (isDefective)
        {
            //Debug.Log("SECOND: " + isDefective);
            //Debug.Log("DEFECTIVE!!!!!!!!");
            defectiveIndicator.SetActive(true);
            Explosion.Invoke();
            Explosion.AddListener(startExplosion);
            flyClass.SetFly(fly);
            PushButton.gameObject.SetActive(false);


        }
        else
        {
            //Debug.Log("Normal");
  
        }


    }

   






    }
