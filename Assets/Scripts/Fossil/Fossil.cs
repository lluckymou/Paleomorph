using UnityEngine;

public abstract class Fossil : MonoBehaviour
{

    [Header("Descriptive attributes")]
    public string Name;
    public string Description;
    public FossilSpecies Species;
    public FossilType Type;
    [SerializeField] FossilEnumeration Enumeration;

    [Header("Fossil Utils")]
    public Sprite Icon;

    [Header("Fossil Gameobjects")]
    public GameObject BodyPart;

    public void Equip(FossilEnumeration fossil = 0)
    {
        switch(Species)
        {
            case FossilSpecies.Abelisaurus:
                if(Inventory.Abelisaurus == UnlockSteps.Unlocked) break;

                if(Inventory.Abelisaurus == UnlockSteps.Locked)
                {
                    Debug.Log("Abelisaurus desbloqueado");
                    Inventory.Abelisaurus = UnlockSteps.FirstFossil;
                }
                else if(Inventory.Abelisaurus != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Abelisaurus atualizado");
                    Inventory.Abelisaurus++;
                }
                break;

            case FossilSpecies.Desmodus:
                if(Inventory.Desmodus == UnlockSteps.Unlocked) break;

                if(Inventory.Desmodus == UnlockSteps.Locked)
                {
                    Debug.Log("Desmodus desbloqueado");
                    Inventory.Desmodus = UnlockSteps.FirstFossil;
                }
                else if(Inventory.Desmodus != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Desmodus atualizado");
                    Inventory.Desmodus++;
                }
                break;

            case FossilSpecies.Eremotherium:
                if(Inventory.Eremotherium == UnlockSteps.Unlocked) break;

                if(Inventory.Eremotherium == UnlockSteps.Locked)
                {
                    Debug.Log("Eremotherium desbloqueado");
                    Inventory.Eremotherium = UnlockSteps.FirstFossil;
                }
                else if(Inventory.Eremotherium != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Eremotherium atualizado");
                    Inventory.Eremotherium++;
                }
                break;

            case FossilSpecies.Glyptodon:
                if(Inventory.Glyptodon == UnlockSteps.Unlocked) break;

                if(Inventory.Glyptodon == UnlockSteps.Locked)
                {
                    Debug.Log("Glyptodon desbloqueado");
                    Inventory.Glyptodon = UnlockSteps.FirstFossil;
                }
                else if(Inventory.Glyptodon != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Glyptodon atualizado");
                    Inventory.Glyptodon++;
                }
                break;

            case FossilSpecies.Vinctifer:
                if(Inventory.Vinctifer == UnlockSteps.Unlocked) break;

                if(Inventory.Vinctifer == UnlockSteps.Locked)
                {
                    Debug.Log("Vinctifer desbloqueado");
                    Inventory.Vinctifer = UnlockSteps.FirstFossil;
                }
                else if(Inventory.Vinctifer != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Vinctifer atualizado");
                    Inventory.Vinctifer++;
                }
                break;

            default: break;
        }
        
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
}