using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilBarrier : MonoBehaviour
{
    public FossilEnumeration fossil;

    void Start()
    {
        Transform t = FossilUtils.instance.NewRock(Fossils.GetItemFromEnumeration(fossil).Icon, transform.parent).transform;
        t.localPosition = transform.localPosition + t.GetComponent<RockPositionDifference>().Difference;
    }

    void OnTriggerEnter(Collider col)
    {
        FossilChoices parent = transform.parent.GetComponent<FossilChoices>();

        if(parent.active) return;
        parent.active = true;

        Player.instance.GetComponent<ParticleSystem>().Play();
        Player.instance.transformPlayer.Play();
        Fossils.GetItemFromEnumeration(fossil).Equip(fossil);
        parent.DestroyChildren();
    }
}
