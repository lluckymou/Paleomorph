using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldElement : MonoBehaviour
{
    public float size = 20;

    void Update()
    {
        transform.Translate(new Vector3(0, 0, -Player.speed * Time.deltaTime));
        
        if(transform.position.z < -50) 
            Destroy(this.gameObject);
    }
}
