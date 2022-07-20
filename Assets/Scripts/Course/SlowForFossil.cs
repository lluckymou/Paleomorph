using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowForFossil : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Player.speed -= Score.Value > 10 ? 1.5f : 3.5f;
        Player.instance.fossilTutorial.SetActive(true);
    }

    void OnTriggerExit(Collider col)
    {
        Player.speed += Score.Value > 10 ? 1.5f : 3.5f;
        Player.instance.fossilTutorial.SetActive(false);
    }
}
