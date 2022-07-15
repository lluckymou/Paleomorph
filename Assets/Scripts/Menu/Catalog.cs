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
    [SerializeField] Color locked;

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
        description.text = CatalogInfo.AbelisaurusCharacteristics;
        species.sprite = ci.AbelisaurusSprite;
        speciesName.text = ci.AbelisaurusName;
        scientificName.text = ci.AbelisaurusScientificName;
        popularName.text = ci.AbelisaurusNickname;

        buyButton.transform.GetChild(0).GetComponent<Text>().text = ci.AbelisaurusPrice.ToString();

        LoadPanel(Inventory.Abelisaurus);

        selectButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Selecionou Abelisaurus");
            panel.SetActive(false);
            Inventory.Starter = FossilSpecies.Abelisaurus;

            Human.GetComponent<Image>().color = unlocked;
            Abelisaurus.GetComponent<Image>().color = selected;
            Desmodus.GetComponent<Image>().color = (Inventory.Desmodus == UnlockSteps.Locked)? locked : unlocked;
            Eremotherium.GetComponent<Image>().color = (Inventory.Eremotherium == UnlockSteps.Locked)? locked : unlocked;
            Glyptodon.GetComponent<Image>().color = (Inventory.Glyptodon == UnlockSteps.Locked)? locked : unlocked;
            Vinctifer.GetComponent<Image>().color = (Inventory.Vinctifer == UnlockSteps.Locked)? locked : unlocked;
        });

        buyButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Comprou Abelisaurus");
            if(Inventory.Rocks < ci.AbelisaurusPrice) return;
            Inventory.Rocks -= ci.AbelisaurusPrice;

            Inventory.Abelisaurus = UnlockSteps.Unlocked;
            buyButton.SetActive(false);
            selectButton.SetActive(true);
        });
    }

    public void GenerateDesmodus()
    {
        if(Inventory.Desmodus == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.DesmodusLocation;
        description.text = CatalogInfo.DesmodusCharacteristics;
        species.sprite = ci.DesmodusSprite;
        speciesName.text = ci.DesmodusName;
        scientificName.text = ci.DesmodusScientificName;
        popularName.text = ci.DesmodusNickname;

        buyButton.transform.GetChild(0).GetComponent<Text>().text = ci.DesmodusPrice.ToString();

        LoadPanel(Inventory.Desmodus);

        selectButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Selecionou Desmodus");
            panel.SetActive(false);
            Inventory.Starter = FossilSpecies.Desmodus;

            Human.GetComponent<Image>().color = unlocked;
            Abelisaurus.GetComponent<Image>().color = (Inventory.Abelisaurus == UnlockSteps.Locked)? locked : unlocked;
            Desmodus.GetComponent<Image>().color = selected;
            Eremotherium.GetComponent<Image>().color = (Inventory.Eremotherium == UnlockSteps.Locked)? locked : unlocked;
            Glyptodon.GetComponent<Image>().color = (Inventory.Glyptodon == UnlockSteps.Locked)? locked : unlocked;
            Vinctifer.GetComponent<Image>().color = (Inventory.Vinctifer == UnlockSteps.Locked)? locked : unlocked;
        });

        buyButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Comprou Desmodus");
            if(Inventory.Rocks < ci.DesmodusPrice) return;
            Inventory.Rocks -= ci.DesmodusPrice;

            Inventory.Desmodus = UnlockSteps.Unlocked;
            buyButton.SetActive(false);
            selectButton.SetActive(true);
        });
    }

    public void GenerateEremotherium()
    {
        if(Inventory.Eremotherium == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.EremotheriumLocation;
        description.text = CatalogInfo.EremotheriumCharacteristics;
        species.sprite = ci.EremotheriumSprite;
        speciesName.text = ci.EremotheriumName;
        scientificName.text = ci.EremotheriumScientificName;
        popularName.text = ci.EremotheriumNickname;

        buyButton.transform.GetChild(0).GetComponent<Text>().text = ci.EremotheriumPrice.ToString();

        LoadPanel(Inventory.Eremotherium);

        selectButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Selecionou Eremotherium");
            panel.SetActive(false);
            Inventory.Starter = FossilSpecies.Eremotherium;

            Human.GetComponent<Image>().color = unlocked;
            Abelisaurus.GetComponent<Image>().color = (Inventory.Abelisaurus == UnlockSteps.Locked)? locked : unlocked;
            Desmodus.GetComponent<Image>().color = (Inventory.Desmodus == UnlockSteps.Locked)? locked : unlocked;
            Eremotherium.GetComponent<Image>().color = selected;
            Glyptodon.GetComponent<Image>().color = (Inventory.Glyptodon == UnlockSteps.Locked)? locked : unlocked;
            Vinctifer.GetComponent<Image>().color = (Inventory.Vinctifer == UnlockSteps.Locked)? locked : unlocked;
        });

        buyButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Comprou Eremotherium");
            if(Inventory.Rocks < ci.EremotheriumPrice) return;
            Inventory.Rocks -= ci.EremotheriumPrice;

            Inventory.Eremotherium = UnlockSteps.Unlocked;
            buyButton.SetActive(false);
            selectButton.SetActive(true);
        });
    }

    public void GenerateGlyptodon()
    {
        if(Inventory.Glyptodon == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.GlyptodonLocation;
        description.text = CatalogInfo.GlyptodonCharacteristics;
        species.sprite = ci.GlyptodonSprite;
        speciesName.text = ci.GlyptodonName;
        scientificName.text = ci.GlyptodonScientificName;
        popularName.text = ci.GlyptodonNickname;

        buyButton.transform.GetChild(0).GetComponent<Text>().text = ci.GlyptodonPrice.ToString();

        LoadPanel(Inventory.Glyptodon);

        selectButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Selecionou Glyptodon");
            panel.SetActive(false);
            Inventory.Starter = FossilSpecies.Glyptodon;

            Human.GetComponent<Image>().color = unlocked;
            Abelisaurus.GetComponent<Image>().color = (Inventory.Abelisaurus == UnlockSteps.Locked)? locked : unlocked;
            Desmodus.GetComponent<Image>().color = (Inventory.Desmodus == UnlockSteps.Locked)? locked : unlocked;
            Eremotherium.GetComponent<Image>().color = (Inventory.Eremotherium == UnlockSteps.Locked)? locked : unlocked;
            Glyptodon.GetComponent<Image>().color = selected;
            Vinctifer.GetComponent<Image>().color = (Inventory.Vinctifer == UnlockSteps.Locked)? locked : unlocked;
        });

        buyButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Comprou Glyptodon");
            if(Inventory.Rocks < ci.GlyptodonPrice) return;
            Inventory.Rocks -= ci.GlyptodonPrice;

            Inventory.Glyptodon = UnlockSteps.Unlocked;
            buyButton.SetActive(false);
            selectButton.SetActive(true);
        });
    }

    public void GenerateVinctifer()
    {
        if(Inventory.Vinctifer == UnlockSteps.Locked) return;

        CatalogInfo ci = GetComponent<CatalogInfo>();

        location.sprite = ci.VinctiferLocation;
        description.text = CatalogInfo.VinctiferCharacteristics;
        species.sprite = ci.VinctiferSprite;
        speciesName.text = ci.VinctiferName;
        scientificName.text = ci.VinctiferScientificName;
        popularName.text = ci.VinctiferNickname;

        buyButton.transform.GetChild(0).GetComponent<Text>().text = ci.VinctiferPrice.ToString();

        LoadPanel(Inventory.Vinctifer);

        selectButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Selecionou Vinctifer");
            panel.SetActive(false);
            Inventory.Starter = FossilSpecies.Vinctifer;

            Human.GetComponent<Image>().color = unlocked;
            Abelisaurus.GetComponent<Image>().color = (Inventory.Abelisaurus == UnlockSteps.Locked)? locked : unlocked;
            Desmodus.GetComponent<Image>().color = (Inventory.Desmodus == UnlockSteps.Locked)? locked : unlocked;
            Eremotherium.GetComponent<Image>().color = (Inventory.Eremotherium == UnlockSteps.Locked)? locked : unlocked;
            Glyptodon.GetComponent<Image>().color = (Inventory.Glyptodon == UnlockSteps.Locked)? locked : unlocked;
            Vinctifer.GetComponent<Image>().color = selected;
        });

        buyButton.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("Comprou Vinctifer");
            if(Inventory.Rocks < ci.VinctiferPrice) return;
            Inventory.Rocks -= ci.VinctiferPrice;

            Inventory.Vinctifer = UnlockSteps.Unlocked;
            buyButton.SetActive(false);
            selectButton.SetActive(true);
        });
    }

    void LoadPanel(UnlockSteps step)
    {
        panel.SetActive(true);
        unlockButton.SetActive(false);
        buyButton.SetActive(false);
        selectButton.SetActive(false);

        buyButton.GetComponent<Button>().onClick.RemoveAllListeners();
        selectButton.GetComponent<Button>().onClick.RemoveAllListeners();

        if(step == UnlockSteps.FirstFossil)
        {
            unlockButton.SetActive(true);
            unlockButton.transform.GetChild(0).GetComponent<Text>().text = "Colete mais fósseis desta espécie para desbloqueá-la\n\n<b>nProgresso: 33%</b>";
            location.sprite = question;
            description.text = noDescription;
        }
        else if(step == UnlockSteps.SecondFossil)
        {
            unlockButton.SetActive(true);
            unlockButton.transform.GetChild(0).GetComponent<Text>().text = "Colete mais fósseis desta espécie para desbloqueá-la\n\n<b>nProgresso: 66%</b>";
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

    public void SelectHuman()
    {
        Debug.Log("Selecionou Humano");

        Inventory.Starter = FossilSpecies.Human;
        Human.GetComponent<Image>().color = selected;
        Abelisaurus.GetComponent<Image>().color = (Inventory.Abelisaurus == UnlockSteps.Locked)? locked : unlocked;
        Desmodus.GetComponent<Image>().color = (Inventory.Desmodus == UnlockSteps.Locked)? locked : unlocked;
        Eremotherium.GetComponent<Image>().color = (Inventory.Eremotherium == UnlockSteps.Locked)? locked : unlocked;
        Glyptodon.GetComponent<Image>().color = (Inventory.Glyptodon == UnlockSteps.Locked)? locked : unlocked;
        Vinctifer.GetComponent<Image>().color = (Inventory.Vinctifer == UnlockSteps.Locked)? locked : unlocked;
    }
}
