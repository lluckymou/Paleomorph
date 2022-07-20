using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    const float transaltionRate = 6;
    Vector2 startVector = Vector2.zero;

    [SerializeField] GameObject tutorial;

    void Awake() => tutorial.SetActive(true);

    void OnMouseDown()
    {
        startVector = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }
    
    void OnMouseDrag()
    {
        tutorial.SetActive(false);

        Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 distance = startVector - curScreenPoint;
        float movement = Mathf.Clamp(distance.x/(transaltionRate*2), -transaltionRate, transaltionRate);

        if(movement < 0) // right
        {
            if(Player.instance.transform.position.x < 4.25f)
                Player.instance.transform.Translate(-movement * Time.deltaTime, 0, 0);
        }
        else if(movement > 0)
        {
            if(Player.instance.transform.position.x > -4.25f)
                Player.instance.transform.Translate(-movement * Time.deltaTime, 0, 0);
        }
    }
}
