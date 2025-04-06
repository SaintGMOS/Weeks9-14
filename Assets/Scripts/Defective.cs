using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Defective : MonoBehaviour
{
    public bool isDefective;

    public GameObject defectiveIndicator;

    public GameObject created;


    // Diff Classs
    public bool fly;

    public FlyAway flyClass;

    public void SetDefective(bool defectiveValue)
    {

        isDefective = defectiveValue;

        if (isDefective)
        {
            Debug.Log("SECOND: " + isDefective);
            Debug.Log("DEFECTIVE!!!!!!!!");
            defectiveIndicator.SetActive(true);
            flyClass.SetFly(fly);
         
        }
        else
        {
            Debug.Log("Normal");
  
        }










    }

   






    }
