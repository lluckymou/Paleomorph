using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(Player.Lightweight >= 5)
            return;

        if(Player.AquaticAffinity >= 2)
            Player.instance.transform.Translate(0, -1.5f, 0);
        else
        {
            Player.instance.transform.Translate(0, -2.5f, 0);
            if(Player.Sight < 2)
                StartCoroutine(WaitFor.Frames(10, () => {Health.Value--;}));
        }
        
    }

    void OnTriggerExit(Collider col)
    {
        if(Player.AquaticAffinity >= 2)
            Player.instance.transform.Translate(0, 1.5f, 0);
        else
            Player.instance.transform.Translate(0, 2.5f, 0);
    }
}
