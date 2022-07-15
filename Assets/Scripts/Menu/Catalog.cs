using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Catalog : MonoBehaviour
{
    [Header("Selection Buttons")]
    [SerializeField] Button Human;
    [SerializeField] Button Abelisaurus;
    [SerializeField] Button Desmodus;
    [SerializeField] Button Eremotherium;
    [SerializeField] Button Glyptodon;
    [SerializeField] Button Vinctifer;

    [Header("Button Colours")]
    [SerializeField] Color selected;
    [SerializeField] Color unlocked;

    void Start()
    {
        if(Inventory.Abelisaurus != UnlockSteps.Locked)
        {
            Abelisaurus.transform.GetChild(0).GetComponent<Image>().sprite = GetComponent<CatalogInfo>().AbelisaurusSprite;
            Abelisaurus.GetComponent<Image>().color = unlocked;
            Abelisaurus.enabled = true;
        }

        if(Inventory.Desmodus != UnlockSteps.Locked)
        {
            Desmodus.transform.GetChild(0).GetComponent<Image>().sprite = GetComponent<CatalogInfo>().DesmodusSprite;
            Desmodus.GetComponent<Image>().color = unlocked;
            Desmodus.enabled = true;
        }

        if(Inventory.Eremotherium != UnlockSteps.Locked)
        {
            Eremotherium.transform.GetChild(0).GetComponent<Image>().sprite = GetComponent<CatalogInfo>().EremotheriumSprite;
            Eremotherium.GetComponent<Image>().color = unlocked;
            Eremotherium.enabled = true;
        }

        if(Inventory.Glyptodon != UnlockSteps.Locked)
        {
            Glyptodon.transform.GetChild(0).GetComponent<Image>().sprite = GetComponent<CatalogInfo>().GlyptodonSprite;
            Glyptodon.GetComponent<Image>().color = unlocked;
            Glyptodon.enabled = true;
        }

        if(Inventory.Vinctifer != UnlockSteps.Locked)
        {
            Vinctifer.transform.GetChild(0).GetComponent<Image>().sprite = GetComponent<CatalogInfo>().VinctiferSprite;
            Vinctifer.GetComponent<Image>().color = unlocked;
            Vinctifer.enabled = true;
        }
    }

    void Update()
    {
        
    }
}
