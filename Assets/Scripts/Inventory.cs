using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : Singleton<Inventory>
{
    static int rocks = -1;
    static UnlockSteps abelisaurus = UnlockSteps.Unloaded;
    static UnlockSteps desmodus = UnlockSteps.Unloaded;
    static UnlockSteps glyptodon = UnlockSteps.Unloaded;
    static UnlockSteps vinctifer = UnlockSteps.Unloaded;
    static UnlockSteps eremotherium = UnlockSteps.Unloaded;

    public const int UnlockChance = /* One in every: */ 2;

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

    public static UnlockSteps Abelisaurus
    {
        get 
        {
            if(abelisaurus == UnlockSteps.Unloaded)
                abelisaurus = (UnlockSteps) PlayerPrefs.GetInt("Abelisaurus", 1);
            
            return abelisaurus;
        }
        set
        {
            abelisaurus = value;
            PlayerPrefs.SetInt("Abelisaurus", (int) value);
        }
    }
    public static UnlockSteps Desmodus
    {
        get 
        {
            if(desmodus == UnlockSteps.Unloaded)
                desmodus = (UnlockSteps) PlayerPrefs.GetInt("Desmodus", 1);
            
            return desmodus;
        }
        set
        {
            desmodus = value;
            PlayerPrefs.SetInt("Desmodus", (int) value);
        }
    }
    public static UnlockSteps Glyptodon
    {
        get 
        {
            if(glyptodon == UnlockSteps.Unloaded)
                glyptodon = (UnlockSteps) PlayerPrefs.GetInt("Glyptodon", 1);
            
            return glyptodon;
        }
        set
        {
            glyptodon = value;
            PlayerPrefs.SetInt("Glyptodon", (int) value);
        }
    }
    public static UnlockSteps Vinctifer
    {
        get 
        {
            if(vinctifer == UnlockSteps.Unloaded)
                vinctifer = (UnlockSteps) PlayerPrefs.GetInt("Vinctifer", 1);
            
            return vinctifer;
        }
        set
        {
            vinctifer = value;
            PlayerPrefs.SetInt("Vinctifer", (int) value);
        }
    }
    public static UnlockSteps Eremotherium
    {
        get 
        {
            if(eremotherium == UnlockSteps.Unloaded)
                eremotherium = (UnlockSteps) PlayerPrefs.GetInt("Eremotherium", 1);
            
            return eremotherium;
        }
        set
        {
            eremotherium = value;
            PlayerPrefs.SetInt("Eremotherium", (int) value);
        }
    }
}
