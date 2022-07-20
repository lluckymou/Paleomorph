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
    
        _left.fossil = Left == FossilEnumeration.None? RandomFossil() : Left;
        _right.fossil = Right == FossilEnumeration.None? RandomFossil() : Right;
    }

    public void DestroyChildren()
    {
        for(int i = transform.childCount-1; i >= 0; i--)
            Destroy(transform.GetChild(i).gameObject);
    }

    public FossilEnumeration RandomFossil()
    {
        FossilEnumeration random = (FossilEnumeration) Random.Range(1, FossilEnumeration.GetNames(typeof(FossilEnumeration)).Length);
        if(random == Left || random == Right) return RandomFossil();
        else return random;
    }
}
