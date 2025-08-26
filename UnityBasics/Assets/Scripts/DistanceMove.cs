using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceMove : MonoBehaviour
{
    public Vector3 dir;
    public float speed;
    public float totalDist;
    private float distLeft;


    // Start is called before the first frame update
    void Start()
    {
        distLeft = totalDist;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fStep = dir * Time.deltaTime * speed; // convert to dir per second
        distLeft -= fStep.magnitude;
        Vector3 temp = transform.position + fStep;
        if (distLeft > 0)
        {
            transform.position = temp;
        }
        else
        {
            //don't move? Or maybe change direction
            //or reverse direction
            dir = -1 * dir;
            distLeft = totalDist; //reset for next leg
        }
    }
}
