using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinkhole : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(Player.AquaticAffinity >= 2)
            Player.instance.transform.Translate(0, -1.5f, 0);
        else
        {
            if(Player.Lightweight < 5)
                Player.instance.transform.Translate(0, -2.5f, 0);

            if(Player.Sight >= 2 || Player.Lightweight >= 5) return;

            StartCoroutine(WaitFor.Frames(10, () => {Health.Value--;}));
        }
        
    }

    void OnTriggerExit(Collider col)
    {
        if(Player.AquaticAffinity >= 2)
            Player.instance.transform.Translate(0, 1.5f, 0);
        else if(Player.Lightweight < 5)
            Player.instance.transform.Translate(0, 2.5f, 0);
    }
}
