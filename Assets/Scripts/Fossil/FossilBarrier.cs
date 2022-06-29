using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilBarrier : MonoBehaviour
{
    [SerializeField] FossilEnumeration fossil;

    void OnTriggerEnter(Collider col)
    {
        FossilChoices parent = transform.parent.GetComponent<FossilChoices>();

        if(parent.active) return;
        parent.active = true;

        Player.instance.GetComponent<ParticleSystem>().Play();
        Fossils.GetItemFromEnumeration(fossil).Equip(fossil);
        parent.DestroyChildren();
    }
}
