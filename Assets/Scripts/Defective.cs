using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Defective : MonoBehaviour
{
    public bool isDefective;



    public bool fly;

    private FlyAway flyClass;

    public void SetDefective(bool defectiveValue)
    {

        isDefective = defectiveValue;

        if (isDefective)
        {
            Debug.Log("Defective!");
            flyClass.SetFly(fly);
         
        }
        else
        {
            Debug.Log("Normal");
  
        }










    }

   






    }
