using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScroll : MonoBehaviour
{
    void Update()
    {
        if(transform.position.z <= -104)
            transform.position = new Vector3(transform.position.x, transform.position.y, 216);
        
        transform.Translate(0, 0, -Player.speed * Time.deltaTime, Space.World);
    }
}
