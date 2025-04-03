using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Vector2 target;
    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        // On left mouse click, update the target position and start moving
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = true;
        }

        if (isMoving)
        {
            Vector2 currentPos = transform.position;
        
            Vector2 direction = (target - currentPos).normalized;
            float stepTHING = moveSpeed * Time.deltaTime;
      
            float distance = Vector2.Distance(currentPos, target);

           
            if (stepTHING >= distance)
            {
                transform.position = new Vector3(target.x, target.y, transform.position.z);
                isMoving = false;
            }
            else
            {
   
                Vector2 newPos = currentPos + direction * stepTHING;
                transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
            }
        }
    }
}
