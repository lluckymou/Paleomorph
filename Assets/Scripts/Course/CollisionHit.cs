using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHit : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("lose life!");
    }
}
