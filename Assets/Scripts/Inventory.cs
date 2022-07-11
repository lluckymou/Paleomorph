using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : Singleton<Inventory>
{
    static int rocks = -1;

    public static int Rocks
    {
        get 
        {
            if(rocks == -1)
                rocks = PlayerPrefs.GetInt("Rocks", 0);
            
            return rocks;
        }
        set
        {
            rocks = value;
            if(PlayerStats.instance)
                PlayerStats.instance.Rocks = rocks.ToString();

            PlayerPrefs.SetInt("Rocks", value);
        }
    }
}
