using UnityEngine;

public abstract class Fossil : MonoBehaviour
{

    [Header("Descriptive attributes")]
    public string Name;
    public string Description;
    public FossilType Type;
    [SerializeField] FossilEnumeration Enumeration;

    [Header("Fossil Utils")]
    public Sprite Icon;

    [Header("Fossil Gameobjects")]
    public GameObject BodyPart;

    public void Equip(FossilEnumeration fossil = 0)
    {
        // Gets fossil enum to check if player has collected that fossil before to add to their collection
        // TODO TODO
        
        switch(Type)
        {
            case FossilType.Top:
                Fossils.GetItemFromEnumeration(Player.instance.top).OnUnequip();
                Player.instance.top = Enumeration;
                EquippedFossils.instance.Top.sprite = Icon;
                break;
            case FossilType.Middle:
                Fossils.GetItemFromEnumeration(Player.instance.middle).OnUnequip();
                Player.instance.middle = Enumeration;
                EquippedFossils.instance.Middle.sprite = Icon;
                break;
            case FossilType.Bottom:
                Fossils.GetItemFromEnumeration(Player.instance.bottom).OnUnequip();
                Player.instance.bottom = Enumeration;
                EquippedFossils.instance.Bottom.sprite = Icon;
                break;
        }

        OnEquip();
    }

    public abstract void OnEquip();
    public abstract void OnUnequip();
    public abstract void OnScoring();
    public abstract void OnDeath();
    public abstract void OnCollision();
}