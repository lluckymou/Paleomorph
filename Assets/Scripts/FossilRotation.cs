using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilRotation : MonoBehaviour
{
    const float bounds = 20;

    bool left = false;
    float startRotation = 0, rotationRate = 10;

    void Start()
    {
        left = Random.Range(0, 2) == 1;
        rotationRate = Random.Range(8f, 15f);
        startRotation = transform.eulerAngles.y;
    }

    void Update()
    {
        float currentRotation = transform.eulerAngles.y;

        if(left)
            if(currentRotation < startRotation + bounds)
                transform.Rotate(0, rotationRate * Time.deltaTime, 0);
            else left = false;
        else        
            if(currentRotation > startRotation - bounds)
                transform.Rotate(0, -rotationRate * Time.deltaTime, 0);
            else left = true;
    }
}
