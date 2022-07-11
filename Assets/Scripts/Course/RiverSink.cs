using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverSink : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Player.instance.transform.Translate(0, -1.5f, 0);
    }

    void OnTriggerExit(Collider col)
    {
        Player.instance.transform.Translate(0, 1.5f, 0);
    }
}
