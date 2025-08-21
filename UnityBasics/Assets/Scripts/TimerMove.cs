using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMove : MonoBehaviour
{
    public Vector3 dir;
    public float speed;
    public float totalTime;
    private float timeLeft;


    // Start is called before the first frame update
    void Start()
    {
        timeLeft = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        Vector3 fStep = dir * Time.deltaTime * speed; // convert to dir per second
        Vector3 temp = transform.position + fStep;
        if (timeLeft > 0)
        {
            transform.position = temp;
        }

    }
}
