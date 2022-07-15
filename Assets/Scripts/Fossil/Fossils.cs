using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Fossils : SceneSingleton<Fossils>
{
    #if UNITY_EDITOR
    [SerializeField] FossilEnumeration _fossil;
    [SerializeField] bool give;

    void Update()
    {
        if(give)
        {
            give = false;
            Player.instance.GetComponent<ParticleSystem>().Play();
            GetItemFromEnumeration(_fossil).Equip(_fossil);
        }
    }
    #endif

    [Header("Special Fossils")]
    [SerializeField] None _none;

    public static None None
    {
        get => instance._none;
    }

    [Header("Fossils")]
    [SerializeField] AbelisaurusBottom _AbelisaurusBottom;
    public static AbelisaurusBottom AbelisaurusBottom
    {
        get => instance._AbelisaurusBottom;
    }

    [SerializeField] AbelisaurusMiddle _AbelisaurusMiddle;
    public static AbelisaurusMiddle AbelisaurusMiddle
    {
        get => instance._AbelisaurusMiddle;
    }

    [SerializeField] AbelisaurusTop _AbelisaurusTop;
    public static AbelisaurusTop AbelisaurusTop
    {
        get => instance._AbelisaurusTop;
    }

    [SerializeField] DesmodusBottom _DesmodusBottom;
    public static DesmodusBottom DesmodusBottom
    {
        get => instance._DesmodusBottom;
    }

    [SerializeField] DesmodusMiddle _DesmodusMiddle;
    public static DesmodusMiddle DesmodusMiddle
    {
        get => instance._DesmodusMiddle;
    }

    [SerializeField] DesmodusTop _DesmodusTop;
    public static DesmodusTop DesmodusTop
    {
        get => instance._DesmodusTop;
    }

    [SerializeField] EremotheriumBottom _EremotheriumBottom;
    public static EremotheriumBottom EremotheriumBottom
    {
        get => instance._EremotheriumBottom;
    }

    [SerializeField] EremotheriumMiddle _EremotheriumMiddle;
    public static EremotheriumMiddle EremotheriumMiddle
    {
        get => instance._EremotheriumMiddle;
    }

    [SerializeField] EremotheriumTop _EremotheriumTop;
    public static EremotheriumTop EremotheriumTop
    {
        get => instance._EremotheriumTop;
    }

    [SerializeField] GlyptodonBottom _GlyptodonBottom;
    public static GlyptodonBottom GlyptodonBottom
    {
        get => instance._GlyptodonBottom;
    }

    [SerializeField] GlyptodonMiddle _GlyptodonMiddle;
    public static GlyptodonMiddle GlyptodonMiddle
    {
        get => instance._GlyptodonMiddle;
    }

    [SerializeField] GlyptodonTop _GlyptodonTop;
    public static GlyptodonTop GlyptodonTop
    {
        get => instance._GlyptodonTop;
    }

    [SerializeField] VinctiferBottom _VinctiferBottom;
    public static VinctiferBottom VinctiferBottom
    {
        get => instance._VinctiferBottom;
    }

    [SerializeField] VinctiferMiddle _VinctiferMiddle;
    public static VinctiferMiddle VinctiferMiddle
    {
        get => instance._VinctiferMiddle;
    }

    [SerializeField] VinctiferTop _VinctiferTop;
    public static VinctiferTop VinctiferTop
    {
        get => instance._VinctiferTop;
    }


    static Dictionary<Fossil, FossilEnumeration> fossilIDs
    {
        get => new Dictionary<Fossil, FossilEnumeration>()
        {
            {None, FossilEnumeration.None},
            {AbelisaurusBottom, FossilEnumeration.AbelisaurusBottom},
            {AbelisaurusMiddle, FossilEnumeration.AbelisaurusMiddle},
            {AbelisaurusTop, FossilEnumeration.AbelisaurusTop},
            {DesmodusBottom, FossilEnumeration.DesmodusBottom},
            {DesmodusMiddle, FossilEnumeration.DesmodusMiddle},
            {DesmodusTop, FossilEnumeration.DesmodusTop},
            {EremotheriumBottom, FossilEnumeration.EremotheriumBottom},
            {EremotheriumMiddle, FossilEnumeration.EremotheriumMiddle},
            {EremotheriumTop, FossilEnumeration.EremotheriumTop},
            {GlyptodonBottom, FossilEnumeration.GlyptodonBottom},
            {GlyptodonMiddle, FossilEnumeration.GlyptodonMiddle},
            {GlyptodonTop, FossilEnumeration.GlyptodonTop},
            {VinctiferBottom, FossilEnumeration.VinctiferBottom},
            {VinctiferMiddle, FossilEnumeration.VinctiferMiddle},
            {VinctiferTop, FossilEnumeration.VinctiferTop},
        };
    }
        

    public static FossilEnumeration GetEnumerationFromItem(Fossil fossil)
    {
        if (fossilIDs.TryGetValue(fossil, out FossilEnumeration enumFossil))
            return enumFossil;
        else return FossilEnumeration.None;
    }

    public static Fossil GetItemFromEnumeration(FossilEnumeration fossil) =>
        fossilIDs.FirstOrDefault(i => i.Value == fossil).Key;

    void Start()
    {
        switch(Inventory.Starter)
        {
            case FossilSpecies.Abelisaurus:
                GetItemFromEnumeration(FossilEnumeration.AbelisaurusTop).Equip(FossilEnumeration.AbelisaurusTop);
                GetItemFromEnumeration(FossilEnumeration.AbelisaurusMiddle).Equip(FossilEnumeration.AbelisaurusMiddle);
                GetItemFromEnumeration(FossilEnumeration.AbelisaurusBottom).Equip(FossilEnumeration.AbelisaurusBottom);
                break;

            case FossilSpecies.Desmodus:
                GetItemFromEnumeration(FossilEnumeration.DesmodusTop).Equip(FossilEnumeration.DesmodusTop);
                GetItemFromEnumeration(FossilEnumeration.DesmodusMiddle).Equip(FossilEnumeration.DesmodusMiddle);
                GetItemFromEnumeration(FossilEnumeration.DesmodusBottom).Equip(FossilEnumeration.DesmodusBottom);
                break;

            case FossilSpecies.Eremotherium:
                GetItemFromEnumeration(FossilEnumeration.EremotheriumTop).Equip(FossilEnumeration.EremotheriumTop);
                GetItemFromEnumeration(FossilEnumeration.EremotheriumMiddle).Equip(FossilEnumeration.EremotheriumMiddle);
                GetItemFromEnumeration(FossilEnumeration.EremotheriumBottom).Equip(FossilEnumeration.EremotheriumBottom);
                break;

            case FossilSpecies.Glyptodon:
                GetItemFromEnumeration(FossilEnumeration.GlyptodonTop).Equip(FossilEnumeration.GlyptodonTop);
                GetItemFromEnumeration(FossilEnumeration.GlyptodonMiddle).Equip(FossilEnumeration.GlyptodonMiddle);
                GetItemFromEnumeration(FossilEnumeration.GlyptodonBottom).Equip(FossilEnumeration.GlyptodonBottom);
                break;

            case FossilSpecies.Vinctifer:
                GetItemFromEnumeration(FossilEnumeration.VinctiferTop).Equip(FossilEnumeration.VinctiferTop);
                GetItemFromEnumeration(FossilEnumeration.VinctiferMiddle).Equip(FossilEnumeration.VinctiferMiddle);
                GetItemFromEnumeration(FossilEnumeration.VinctiferBottom).Equip(FossilEnumeration.VinctiferBottom);
                break;

            default: break;
        }
    }
}