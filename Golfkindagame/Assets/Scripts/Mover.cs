using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    int xVelocitty=10;
    float tiltAngle = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(10 *Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        if(xValue!=0){
            if(xValue>0)xVelocitty=10;
            if(xValue<0)xVelocitty=5;

            float tiltAroundZ = zValue * tiltAngle;
            float tiltAroundX = xValue * tiltAngle;

            transform.Translate(xValue * Time.deltaTime * xVelocitty, 0, 0);
        }

        if(zValue>0)transform.Translate(+0, 0, +0.5f * Time.deltaTime * 20);
    }
}
