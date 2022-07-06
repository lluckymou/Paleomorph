using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilChoices : MonoBehaviour
{
    [HideInInspector] public bool active = false; 
    public FossilEnumeration Left, Right;

    public void Start()
    {
        FossilBarrier _left = transform.GetChild(0).gameObject.AddComponent(typeof(FossilBarrier)) as FossilBarrier;
        FossilBarrier _right = transform.GetChild(1).gameObject.AddComponent(typeof(FossilBarrier)) as FossilBarrier;
    
        _left.fossil = Left;
        _right.fossil = Right;
    }

    public void DestroyChildren()
    {
        for(int i = transform.childCount-1; i >= 0; i--)
            Destroy(transform.GetChild(i).gameObject);
    }
}
