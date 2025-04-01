using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab; // Package Prefab
    public GameObject spawnLocation; // Spawn Location of the Package
    private GameObject package; // Ref to the currently spawned Package(Grabs the prefab building having its movement script)
    public float destroyTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    
    }



    public void Spawn()
    { 
        package = Instantiate(prefab, spawnLocation.transform.position, Quaternion.identity);
        
    
    
    
    }


}
