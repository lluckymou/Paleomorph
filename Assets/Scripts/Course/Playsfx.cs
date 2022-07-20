using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsfx : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GetComponent<AudioSource>()?.Play();
    }

    void OnTriggerExit(Collider col)
    {
        GetComponent<AudioSource>()?.Stop();
    }
}
