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

    [Header("Gameobjects")]
    [SerializeField] GameObject buyButton;
    [SerializeField] GameObject unlockButton;
    [SerializeField] GameObject selectButton;
    [SerializeField] GameObject panel;
    [SerializeField] Image location;
    [SerializeField] Image species;
    [SerializeField] Text speciesName;
    [SerializeField] Text scientificName;
    [SerializeField] Text popularName;
    [SerializeField] Text description;

    [Header("Other")]
    [SerializeField] Sprite question;

    const string noDescription = @"Características:

  • ???????????? ???????? ?????;
  • ?????????? ????????? ??????? ????;
  • ????????????? ???? ????? ?? ??????;
  • ??????? ???? ?????? ???? ?????;";

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

    public void GenerateAbelisaurus()
    {
        if(Inventory.Abelisaurus == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.AbelisaurusLocation;
        description.text = ci.AbelisaurusText;
        species.sprite = ci.AbelisaurusSprite;
        speciesName.text = ci.AbelisaurusName;
        scientificName.text = ci.AbelisaurusScientificName;
        popularName.text = ci.AbelisaurusNickname;

        LoadPanel(Inventory.Abelisaurus);
    }

    public void GenerateDesmodus()
    {
        if(Inventory.Desmodus == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.DesmodusLocation;
        description.text = ci.DesmodusText;
        species.sprite = ci.DesmodusSprite;
        speciesName.text = ci.DesmodusName;
        scientificName.text = ci.DesmodusScientificName;
        popularName.text = ci.DesmodusNickname;

        LoadPanel(Inventory.Desmodus);
    }

    public void GenerateEremotherium()
    {
        if(Inventory.Eremotherium == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.EremotheriumLocation;
        description.text = ci.EremotheriumText;
        species.sprite = ci.EremotheriumSprite;
        speciesName.text = ci.EremotheriumName;
        scientificName.text = ci.EremotheriumScientificName;
        popularName.text = ci.EremotheriumNickname;

        LoadPanel(Inventory.Eremotherium);
    }

    public void GenerateGlyptodon()
    {
        if(Inventory.Glyptodon == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.GlyptodonLocation;
        description.text = ci.GlyptodonText;
        species.sprite = ci.GlyptodonSprite;
        speciesName.text = ci.GlyptodonName;
        scientificName.text = ci.GlyptodonScientificName;
        popularName.text = ci.GlyptodonNickname;

        LoadPanel(Inventory.Glyptodon);
    }

    public void GenerateVinctifer()
    {
        if(Inventory.Vinctifer == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.VinctiferLocation;
        description.text = ci.VinctiferText;
        species.sprite = ci.VinctiferSprite;
        speciesName.text = ci.VinctiferName;
        scientificName.text = ci.VinctiferScientificName;
        popularName.text = ci.VinctiferNickname;

        LoadPanel(Inventory.Vinctifer);
    }

    void LoadPanel(UnlockSteps step)
    {
        panel.SetActive(true);
        unlockButton.SetActive(false);
        buyButton.SetActive(false);
        selectButton.SetActive(false);

        if(step == UnlockSteps.FirstFossil)
        {
            unlockButton.SetActive(true);
            unlockButton.transform.GetChild(0).GetComponent<Text>().text = "Colete mais fósseis desta espécie para desbloqueá-la\n\nProgresso: 33%";
            location.sprite = question;
            description.text = noDescription;
        }
        else if(step == UnlockSteps.SecondFossil)
        {
            unlockButton.SetActive(true);
            unlockButton.transform.GetChild(0).GetComponent<Text>().text = "Colete mais fósseis desta espécie para desbloqueá-la\n\nProgresso: 66%";
            description.text = noDescription;
        }
        else if(step == UnlockSteps.ThirdFossil)
        {
            buyButton.SetActive(true);
        }
        else if(step == UnlockSteps.Unlocked)
        {
            selectButton.SetActive(true);
        }
    }
}
