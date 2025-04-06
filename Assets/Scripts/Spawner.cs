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
    public float destroyTime; // Time (in seconds) after which the spawned package will be destroyed


    // UI/Visual
    public GameObject created; // Reference to a "green block"
    
    // Unity Event
    public UnityEvent PackageSpawned; // UnityEvent that is invoked after spawning a package

    // Defective Package Handling
    public bool defective;              // Flag indicating whether the current package is defective
    public Defective defectiveClass;    // Reference to a Defective script/component that handles defective packages




    void Start()
    {
        // When the event is invoked, 'green' will be called.
        PackageSpawned.AddListener(green);
    }

    // This method is called when the PackageSpawned event is invoked.
    // It activates the 'created' GameObject.
    private void green()
    {
        created.SetActive(true);
        //Debug.Log("G");
    }



    public void Spawn()
    {
        // Determine if the spawned package is defective.
        // For ex, there's a 15% chance the package is defective.
        bool isDefective = Random.value < 0.15f;

        defective = isDefective;

        // If a Defective script is assigned, update its defective status.
        if (defectiveClass != null)
        {

            //Debug.Log("FIRST: " + defective);
            // Will handle any logic for defective packages.
            defectiveClass.SetDefective(defective);



        }

        // Instantiate a new package at the specified spawn location.
        package = Instantiate(prefab, spawnLocation.transform.position, Quaternion.identity);

        // If the package is defective, enable FlyAway.
        if (isDefective)
        {

            // Attempt to get the FlyAway component from the newly spawned package.
            FlyAway flyAway = package.GetComponent<FlyAway>();

            if (flyAway != null)
            {
                // Start the flying behavior by calling SetFly(true)
                flyAway.SetFly(true);

            }
            else
            {

                //Debug.LogWarning("FlyAway component AINT FREAKIN WORKIN.");

            }
        }

        // Destory of the spawned package after destroyTime seconds.
        Destroy(package,destroyTime);

        // Invoke the PackageSpawned event to notify any listeners.
        PackageSpawned.Invoke();
    }

    
   





}
