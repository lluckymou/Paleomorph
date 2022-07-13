using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudSink : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(Player.Lightweight <= 2)
            Player.instance.transform.Translate(0, -1, 0);
        else return;

        Player.speed -= 2;

        if(Player.Defense <= 2)
            StartCoroutine(WaitFor.Frames(10, () => {Health.Value--;}));
    }

    void OnTriggerExit(Collider col)
    {
        if(Player.Lightweight <= 2)
            Player.instance.transform.Translate(0, 1, 0);
        else return;

        Player.speed += 2;
    }
}
