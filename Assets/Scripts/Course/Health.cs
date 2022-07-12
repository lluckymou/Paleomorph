﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : SceneSingleton<Health>
{
    [SerializeField] Image heart;

    [Header("Icons")]
    [SerializeField] Sprite heartIcon;
    [SerializeField] Sprite halfHeartIcon;
    [SerializeField] GameObject damagePanel;
    
    int health = 2;

    public static int Value
    {
        get => instance.health;
        set 
        {
            instance.health = value;
            
            if(value > 1)
            {
                instance.heart.sprite = instance.heartIcon;
            }
            if(value == 1)
            {
                instance.damagePanel.SetActive(true);
                instance.heart.sprite = instance.halfHeartIcon;
            }
            else if(value <= 0)
            {
                instance.damagePanel.SetActive(true);
                instance.heart.gameObject.SetActive(false);
                Player.speed = 0;
                // FAZER MORTE AQUI
            }
        }
    }

    void Awake()
    {
        damagePanel.SetActive(false);
        Value = 2;
    }

    float timer = 0.5f;
    void Update()
    {
        if(damagePanel.activeInHierarchy)
        {
            timer -= Time.deltaTime;

            if(timer < 0)
            {
                timer = 0.5f;
                damagePanel.SetActive(false);
            }
        }
    }
}