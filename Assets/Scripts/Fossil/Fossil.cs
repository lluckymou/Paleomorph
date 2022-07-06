using UnityEngine;

public abstract class Fossil : MonoBehaviour
{

    [Header("Descriptive attributes")]
    public string Name;
    public string Description;

    [Header("Fossil Utils")]
    public Sprite Icon;

    [Header("Fossil Gameobjects")]
    public GameObject BodyPart;

    public void Equip(FossilEnumeration fossil = 0)
    {
        // Gets fossil enum to check if player has collected that fossil before to add to their collection
        // TODO TODO
        OnEquip();
    }

    public abstract void OnEquip();
    public abstract void OnUnequip();
    public abstract void OnScoring();
    public abstract void OnDeath();
    public abstract void OnCollision();
}