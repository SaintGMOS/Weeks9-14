using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mover : MonoBehaviour
{

    public GameObject prefab;
    public float speed = 0.1f;

    private bool startMove = false;

    public Spawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        if (spawner != null)
        {
            spawner.PackageSpawned.AddListener(StartMoving);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (startMove)
        {
            Vector3 loc = transform.position;

            loc.x += speed;

            transform.position = loc;
        }
    }



    public void StartMoving()
    {

        startMove = true;

    }


}
