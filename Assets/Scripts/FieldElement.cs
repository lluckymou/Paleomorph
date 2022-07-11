using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldElement : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -Player.speed * Time.deltaTime));
        
        if(transform.position.z < -10) 
            Destroy(this.gameObject);
    }
}
