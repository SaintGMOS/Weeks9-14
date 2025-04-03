using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defective : MonoBehaviour
{
    public bool isDefective;


    public void SetDefective(bool defectiveValue)
    {

        isDefective = defectiveValue;

        if (isDefective)
        {
            Debug.Log("Defective!");
         
        }
        else
        {
            Debug.Log("Normal");
  
        }


    }




    }
