using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : SceneSingleton<PlayerStats>
{
    [SerializeField] Text rocks;

    [Header("Used only in the game scene")]
    [SerializeField] Text sight;
    [SerializeField] Text aqua;
    [SerializeField] Text weight;
    [SerializeField] Text damage;
    
    void Awake()
    {
        Rocks = PlayerPrefs.GetInt("Rocks", 0).ToString();
    }

    public string Rocks
    {
        get => rocks.text;
        set
        {
            rocks.text = value;
        }
    }

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
