using UnityEngine;
using UnityEngine.UI;

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
        bool updated = false;
        switch(Species)
        {
            case FossilSpecies.Abelisaurus:
                if(Inventory.Abelisaurus == UnlockSteps.Unlocked) break;

                if(Inventory.Abelisaurus == UnlockSteps.Locked)
                {
                    Debug.Log("Abelisaurus desbloqueado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Abelisaurus;
                    Inventory.Abelisaurus = UnlockSteps.FirstFossil;
                    updated = true;
                }
                else if(Inventory.Abelisaurus != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Abelisaurus atualizado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Abelisaurus;
                    updated = true;
                    Inventory.Abelisaurus++;
                }
                break;

            case FossilSpecies.Desmodus:
                if(Inventory.Desmodus == UnlockSteps.Unlocked) break;

                if(Inventory.Desmodus == UnlockSteps.Locked)
                {
                    Debug.Log("Desmodus desbloqueado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Desmodus;
                    Inventory.Desmodus = UnlockSteps.FirstFossil;
                    updated = true;
                }
                else if(Inventory.Desmodus != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Desmodus atualizado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Desmodus;
                    updated = true;
                    Inventory.Desmodus++;
                }
                break;

            case FossilSpecies.Eremotherium:
                if(Inventory.Eremotherium == UnlockSteps.Unlocked) break;

                if(Inventory.Eremotherium == UnlockSteps.Locked)
                {
                    Debug.Log("Eremotherium desbloqueado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Eremotherium;
                    Inventory.Eremotherium = UnlockSteps.FirstFossil;
                    updated = true;
                }
                else if(Inventory.Eremotherium != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Eremotherium atualizado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Eremotherium;
                    updated = true;
                    Inventory.Eremotherium++;
                }
                break;

            case FossilSpecies.Glyptodon:
                if(Inventory.Glyptodon == UnlockSteps.Unlocked) break;

                if(Inventory.Glyptodon == UnlockSteps.Locked)
                {
                    Debug.Log("Glyptodon desbloqueado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Glyptodon;
                    Inventory.Glyptodon = UnlockSteps.FirstFossil;
                    updated = true;
                }
                else if(Inventory.Glyptodon != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Glyptodon atualizado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Glyptodon;
                    updated = true;
                    Inventory.Glyptodon++;
                }
                break;

            case FossilSpecies.Vinctifer:
                if(Inventory.Vinctifer == UnlockSteps.Unlocked) break;

                if(Inventory.Vinctifer == UnlockSteps.Locked)
                {
                    Debug.Log("Vinctifer desbloqueado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Vinctifer;
                    Inventory.Vinctifer = UnlockSteps.FirstFossil;
                    updated = true;
                }
                else if(Inventory.Vinctifer != UnlockSteps.ThirdFossil && Random.Range(0, Inventory.UnlockChance) == 0)
                {
                    Debug.Log("Progresso do Vinctifer atualizado");
                    Player.instance.speciesUnlock.transform.GetChild(0).GetComponent<Image>().sprite = FossilUtils.instance.Vinctifer;
                    updated = true;
                    Inventory.Vinctifer++;
                }
                break;

            default: break;
        }
        
        if(updated)
        {
            Player.instance.speciesUnlock.SetActive(false);
            StartCoroutine(WaitFor.Frames(3, () => {Player.instance.speciesUnlock.SetActive(true);}));
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