using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [Header("X Range")]
    [SerializeField] float minX;
    [SerializeField] float maxX;

    [Header("Y Range")]
    [SerializeField] float minY;
    [SerializeField] float maxY;

    [Header("Z Range")]
    [SerializeField] float minZ;
    [SerializeField] float maxZ;

    void Start()
    {
        transform.Translate(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ), Space.World);
    }
}
