using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    const float transaltionRate = 6;

    void OnMouseDrag()
    {
        float position =  Input.mousePosition.x;
        float objPosition = Camera.main.WorldToScreenPoint(transform.position).x;
        
        if(position - objPosition >= 0) // right
        {
            if(transform.position.x < 4.25f)
                transform.Translate(transaltionRate * Time.deltaTime, 0, 0);
        }
        else 
        {
            if(transform.position.x > -4.25f)
                transform.Translate(-transaltionRate * Time.deltaTime, 0, 0);
        }
    }
}
