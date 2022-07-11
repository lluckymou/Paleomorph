using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverSink : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(Player.Lightweight >= 5) 
            return;
        
        if(Player.Lightweight >= 2)
        {
            Player.instance.transform.Translate(0, -0.5f, 0);
            return;
        }

        Player.instance.transform.Translate(0, -1.5f, 0);

        if(Player.AquaticAffinity <= 2)
        {
            //damage
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(Player.Lightweight >= 5) 
            return;
        
        if(Player.Lightweight >= 2)
        {
            Player.instance.transform.Translate(0, 0.5f, 0);
            return;
        } 

        Player.instance.transform.Translate(0, 1.5f, 0);

        if(Player.AquaticAffinity <= 2)
        {
            //damage
        }
    }
}
