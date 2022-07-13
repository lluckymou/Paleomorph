using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum Stats
{
    Defense,
    Lightweight,
    AquaticAffinity,
    Sight
}

public class CheckStat : MonoBehaviour
{
    [SerializeField] Stats stat;
    TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        int current = 0;
        switch(stat)
        {
            case Stats.Defense: 
                current = Player.Defense;
                break;
            case Stats.Lightweight: 
                current = Player.Lightweight;
                break;
            case Stats.AquaticAffinity: 
                current = Player.AquaticAffinity;
                break;
            case Stats.Sight: 
                current = Player.Sight;
                break;
        }

        if(current < int.Parse(text.text))
            text.color = new Color(125, 0, 0);
        else text.color = Color.white;
    }
}
