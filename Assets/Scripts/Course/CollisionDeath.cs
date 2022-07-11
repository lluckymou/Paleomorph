using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(Player.Lightweight >= 5)
            return;

        Debug.Log("Died in a hole!");
        Player.instance.transform.Translate(0, -2.5f, 0);
    }
}
