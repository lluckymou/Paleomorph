using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Fossils : SceneSingleton<Fossils>
{
    [Header("Special Items")]
    [SerializeField]
    None _none;

    public static None None
    {
        get => instance._none;
    }

    // [Header("Items")]
    // [SerializeField]
    // Fireball _fireball;

    // public static Fireball Fireball
    // {
    //     get => instance._fireball;
    // }

    // [SerializeField]
    // Fireball _fireball;

    // public static Fireball Fireball
    // {
    //     get => instance._fireball;
    // }

    static Dictionary<Fossil, FossilEnumeration> fossilIDs
    {
        get => new Dictionary<Fossil, FossilEnumeration>()
        {
            {None, FossilEnumeration.None},
        };
    }
        

    public static FossilEnumeration GetEnumerationFromItem(Fossil fossil)
    {
        if (fossilIDs.TryGetValue(fossil, out FossilEnumeration enumFossil))
            return enumFossil;
        else return FossilEnumeration.None;
    }

    public static Fossil GetItemFromEnumeration(FossilEnumeration fossil) =>
        fossilIDs.FirstOrDefault(i => i.Value == fossil).Key;
}