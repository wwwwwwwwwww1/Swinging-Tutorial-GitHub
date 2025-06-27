using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float distance = 10f;           
    public float speedForward = 15f;      
    public float speedReturn = 5f;        

    private Vector3 startPos;
    private Vector3 endPos;
    private bool goingForward = true;
    private Rigidbody rb;

    void Start()
    {
        startPos = transform.position;
        endPos = startPos + transform.right * distance;  
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void FixedUpdate()
    {
        float step = (goingForward ? speedForward : speedReturn) * Time.fixedDeltaTime;
        Vector3 target = goingForward ? endPos : startPos;

        rb.MovePosition(Vector3.MoveTowards(transform.position, target, step));

        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            goingForward = !goingForward;
        }
    }
}
