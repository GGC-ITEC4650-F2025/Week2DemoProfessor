using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public Vector3 dir;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fStep = dir * Time.deltaTime * speed; // convert to dir per second
        Vector3 temp = transform.position + fStep;
        if (temp.x >= -5 && temp.x <= 5)
        {
            transform.position = temp;
        }
        else
        {
            //don't move? Or maybe change direction

            //reverse direction
            dir = -1 * dir;
        }
    }
}
