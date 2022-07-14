using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilChoices : MonoBehaviour
{
    [HideInInspector] public bool active = false; 
    public FossilEnumeration Left, Right;
    [SerializeField] bool automatic = true;

    public void Start()
    {
        if(automatic) Generate();
    }

    public void Generate()
    {
        FossilBarrier _left = transform.GetChild(0).gameObject.AddComponent(typeof(FossilBarrier)) as FossilBarrier;
        FossilBarrier _right = transform.GetChild(1).gameObject.AddComponent(typeof(FossilBarrier)) as FossilBarrier;
    
        _left.fossil = Left == FossilEnumeration.None? (FossilEnumeration) Random.Range(0, FossilEnumeration.GetNames(typeof(FossilEnumeration)).Length) : Left;
        _right.fossil = Right == FossilEnumeration.None? (FossilEnumeration) Random.Range(0, FossilEnumeration.GetNames(typeof(FossilEnumeration)).Length) : Right;
    }

    public void DestroyChildren()
    {
        for(int i = transform.childCount-1; i >= 0; i--)
            Destroy(transform.GetChild(i).gameObject);
    }
}
