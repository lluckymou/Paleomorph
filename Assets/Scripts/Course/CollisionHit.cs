using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHit : MonoBehaviour
{
    [SerializeField] int minimumDefense = 99;

    void OnTriggerEnter(Collider col)
    {
        if(Player.Defense >= minimumDefense) return;
        
        Health.Value--;
    }
}
