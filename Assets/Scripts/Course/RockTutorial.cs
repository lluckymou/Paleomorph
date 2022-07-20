using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTutorial : MonoBehaviour
{
    [SerializeField] GameObject tutorial;

    void OnTriggerEnter(Collider col)
    {
        tutorial.SetActive(true);
    }

    void OnTriggerExit(Collider col)
    {
        tutorial.SetActive(false);
    }
}
