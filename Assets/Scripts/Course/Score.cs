using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : SceneSingleton<Score>
{
    [SerializeField] Text scoreLabel;
    int score = 0;

    public static int Value
    {
        get => instance.score;
        set 
        {
            instance.score = value;
            if(instance.score > 15) Player.speed += 0.2f; 
            instance.scoreLabel.text = value.ToString();
        }
    }

    void Awake()
    {
        Value = 0;
    }
}
