using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : SceneSingleton<PlayerStats>
{
    [SerializeField] Text sight, aqua, weight, damage;
    
    public string Sight
    {
        get => sight.text;
        set
        {
            sight.text = value;
        }
    }

    public string AquaticAffinity
    {
        get => aqua.text;
        set
        {
            aqua.text = value;
        }
    }

    public string Weight
    {
        get => weight.text;
        set
        {
            weight.text = value;
        }
    }

    public string Damage
    {
        get => damage.text;
        set
        {
            damage.text = value;
        }
    }
}
