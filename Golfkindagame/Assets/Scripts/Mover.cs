using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    int xVelocitty=10;
    float smooth = 2.0f;
    float tiltAngle = 30.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var lookDir = position-transform.position;
        lookDir.z = 0; // keep only the horizontal direction

        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        if(xValue!=0){
            if(xValue>0)xVelocitty=10;
            if(xValue<0)xVelocitty=5;

            float tiltAroundZ = zValue * tiltAngle;
            float tiltAroundX = xValue * tiltAngle;

            if(zValue<0)transform.Rotate(0, 0.5f, 0);
            if(zValue>0)transform.Rotate(0, -0.5f, 0);

            transform.rotation = Quaternion.LookRotation(lookDir);

            transform.Translate(xValue * Time.deltaTime * xVelocitty, 0, 0);
        }
    }
}
