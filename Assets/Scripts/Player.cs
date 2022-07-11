﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SceneSingleton<Player>
{
    #if UNITY_EDITOR
        public bool resetRocks;

        void Update()
        {
            if(resetRocks)
            {
                resetRocks = false;
                Inventory.Rocks = 0;
            }
        }
    #endif

    [Header("Game Objects")]
    [SerializeField] GameObject _head;
    [SerializeField] GameObject _body;
    [SerializeField] GameObject _legs;

    [Header("Equipped")]
    public FossilEnumeration top;
    public FossilEnumeration middle;
    public FossilEnumeration bottom;

    public static float speed = 10;

    public void SetTop(GameObject head)
    {
        if(_head) Destroy(_head);

        _head = Instantiate(head, transform);
        _head.transform.localPosition = new Vector3(0, 1, 0);
    }

    public void SetMiddle(GameObject body)
    {
        if(_body) Destroy(_body);

        _body = Instantiate(body, transform);
        _body.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void SetBottom(GameObject legs)
    {
        if(_legs) Destroy(_legs);

        _legs = Instantiate(legs, transform);
        _legs.transform.localPosition = new Vector3(0, -1, 0);
    }

    private static int _sight, _aquaticAffinity, _weight, _damage;

    public static int Sight
    {
        get => _sight;
        set
        {
            _sight = value;
            PlayerStats.instance.Sight = _sight.ToString();
        }
    }

    public static int AquaticAffinity
    {
        get => _aquaticAffinity;
        set
        {
            _aquaticAffinity = value;
            PlayerStats.instance.AquaticAffinity = _aquaticAffinity.ToString();
        }
    }

    public static int Weight
    {
        get => _weight;
        set
        {
            _weight = value;
            PlayerStats.instance.Weight = _weight.ToString();
        }
    }

    public static int Damage
    {
        get => _damage;
        set
        {
            _damage = value;
            PlayerStats.instance.Damage = _damage.ToString();
        }
    }

    void Awake()
    {
        Sight = AquaticAffinity = Weight = Damage = 0;
    }
}