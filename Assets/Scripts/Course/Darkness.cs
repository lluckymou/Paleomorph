using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkness : MonoBehaviour
{
    [SerializeField] GameObject blindness;
    [SerializeField] Light sun;

    void Start()
    {
        blindness = GameObject.Find("Canvas").transform.Find("Blindness").gameObject;
        sun = FindObjectOfType<Light>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(Player.Sight < 2)
        {
            blindness.SetActive(true);
            sun.intensity = 0.5f;
        }
        else sun.intensity = 0;

    }

    void OnTriggerExit(Collider col)
    {
        blindness.SetActive(false);
        sun.intensity = 2;
    }
}
