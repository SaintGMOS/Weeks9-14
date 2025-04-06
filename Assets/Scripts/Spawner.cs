using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    // Spawn Settings
    public GameObject prefab; // Package Prefab
    public GameObject spawnLocation; // Spawn Location of the Package
    private GameObject package; // Ref to the currently spawned Package
    public float destroyTime;

    // Green(Block for Created)
    public GameObject created;
    
    // Unity Event
    public UnityEvent PackageSpawned;

    // Other Classes
    public bool defective;

    public Defective defectiveClass;

 


    void Start()
    {
        PackageSpawned.AddListener(green);
    }

    private void green()
    {
        created.SetActive(true);
        //Debug.Log("G");
    }



    public void Spawn()
    { 
        bool isDefective = Random.value < 0.2f;

        defective = isDefective;

        if (defectiveClass != null)
        {

            Debug.Log("FIRST: " + defective);
            defectiveClass.SetDefective(defective);


        }

        package = Instantiate(prefab, spawnLocation.transform.position, Quaternion.identity);


        if (isDefective)
        {
            FlyAway flyAway = package.GetComponent<FlyAway>();
            if (flyAway != null)
            {
                flyAway.SetFly(true);
            }
            else
            {
                Debug.LogWarning("FlyAway component AINT FREAKIN WORKIN.");
            }
        }

        Destroy(package,destroyTime);

        PackageSpawned.Invoke();
    }

    
   





}
