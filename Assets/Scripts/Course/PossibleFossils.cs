using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossibleFossils : MonoBehaviour
{
    [SerializeField] FossilEnumeration[] Fossils;

    void Awake()
    {
        FossilChoices fc = GetComponent<FossilChoices>();

        if(Fossils.Length < 1)
        {
            fc.Generate();
            return;
        }

        FossilEnumeration random = Fossils[Random.Range(0, Fossils.Length)];

        if(Random.Range(0, 2) == 0) 
            fc.Left = random;
        else
            fc.Right = random;

        fc.Generate();
    }
}
