using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("DEATH!");
        Player.instance.transform.Translate(0, -2.5f, 0);
    }
}
