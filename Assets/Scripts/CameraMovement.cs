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
        
        transform.position = new Vector3(
            Mathf.Clamp(
                transform.position.x + ((position - objPosition >= 0? 1 : -1) * transaltionRate * Time.deltaTime),
                -4.25f,
                4.25f
            )
        , 0, 0);
    }
}
