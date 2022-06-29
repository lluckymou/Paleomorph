using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SceneSingleton<Player>
{
    [SerializeField] GameObject _head, _body, _legs;

    public void SetHead(GameObject head)
    {
        if(_head)
        {
            _legs.GetComponent<Fossil>()?.OnUnequip();
            Destroy(_head);
        }

        _head = Instantiate(head, transform);
        _head.transform.localPosition = new Vector3(0, 1, 0);
    }

    public void SetBody(GameObject body)
    {
        if(_body)
        {
            _legs.GetComponent<Fossil>()?.OnUnequip();
            Destroy(_body);
        }

        _body = Instantiate(body, transform);
        _body.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void SetLegs(GameObject legs)
    {
        if(_legs)
        {
            _legs.GetComponent<Fossil>()?.OnUnequip();
            Destroy(_legs);
        }

        _legs = Instantiate(legs, transform);
        _legs.transform.localPosition = new Vector3(0, -1, 0);
    }

    private static int _sight, _hearing, _weight, _damage;

    public static int Sight
    {
        get => _sight;
        set
        {
            _sight = value;
            PlayerStats.instance.Sight = _sight.ToString();
        }
    }

    public static int Hearing
    {
        get => _hearing;
        set
        {
            _hearing = value;
            PlayerStats.instance.Hearing = _hearing.ToString();
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
        Sight = Hearing = Weight = Damage = 0;
    }
}
