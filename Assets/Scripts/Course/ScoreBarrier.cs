using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBarrier : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Score.Value++;
        Destroy(gameObject);
    }
}
