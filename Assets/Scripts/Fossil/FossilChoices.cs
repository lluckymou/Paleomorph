using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilChoices : MonoBehaviour
{
    [HideInInspector] public bool active = false; 

    public void DestroyChildren()
    {
        for(int i = transform.childCount-1; i >= 0; i--)
            Destroy(transform.GetChild(i).gameObject);
    }
}
