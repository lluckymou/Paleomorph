using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBarrier : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Score.Value++;
        CourseGenerator.instance.Distance -= 2.5f;
        CourseGenerator.instance.NewElement();
        Destroy(gameObject);
    }
}
