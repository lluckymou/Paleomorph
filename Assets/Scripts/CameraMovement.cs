using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    const float transaltionRate = 6;

    void OnMouseDrag()
    {
        if(Health.Value <= 0) return;

        float position =  Input.mousePosition.x;
        float objPosition = Camera.main.WorldToScreenPoint(Player.instance.transform.position).x;
        
        if(position - objPosition >= 0) // right
        {
            if(Player.instance.transform.position.x < 4.25f)
                Player.instance.transform.Translate(transaltionRate * Time.deltaTime, 0, 0);
        }
        else 
        {
            if(Player.instance.transform.position.x > -4.25f)
                Player.instance.transform.Translate(-transaltionRate * Time.deltaTime, 0, 0);
        }
    }
}
