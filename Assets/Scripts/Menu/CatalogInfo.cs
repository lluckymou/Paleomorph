using UnityEngine;

public class CatalogInfo : MonoBehaviour
{
    [Header("Abelisaurus")]
    public string AbelisaurusName;
    public string AbelisaurusScientificName;
    public string AbelisaurusNickname;
    public Sprite AbelisaurusSprite;
    public Sprite AbelisaurusLocation;
    public const string AbelisaurusCharacteristics = @"Características:
  • Um dos maiores predadores da sua época;
  • Atacava por emboscada, em alta velocidade;
  • 74 Milhões de anos atrás;
  • 3 Metros de altura e 7 de comprimento;
  • 2 Toneladas (peso de um carro grande).";
    public int AbelisaurusPrice;

    [Header("Desmodus")]
    public string DesmodusName;
    public string DesmodusScientificName;
    public string DesmodusNickname;
    public Sprite DesmodusSprite;
    public Sprite DesmodusLocation;
    public const string DesmodusCharacteristics = @"Características:

  • Último dos grandes mamíferos voadores;
  • Extinto por volta de 1820;
  • 30% maior que morcegos-vampiros comuns;
  • Maior morcego-vampiro que já existiu;
  • Tamanho do seu corpo (envergadura) de aproximadamente meio metro.";
    public int DesmodusPrice;

    [Header("Eremotherium")]
    public string EremotheriumName;
    public string EremotheriumScientificName;
    public string EremotheriumNickname;
    public Sprite EremotheriumSprite;
    public Sprite EremotheriumLocation;
    public const string EremotheriumCharacteristics = @"Características:

  • Conhecido como “preguiça gigante”;
  • 5 Metros de altura;
  • Pesava 5 toneladas;
  • Possivelmente extinta com a chegada dos humanos na América do Sul;
  • Um dos maiores mamíferos que já existiram.";
    public int EremotheriumPrice;

    [Header("Glyptodon")]
    public string GlyptodonName;
    public string GlyptodonScientificName;
    public string GlyptodonNickname;
    public Sprite GlyptodonSprite;
    public Sprite GlyptodonLocation;
    public const string GlyptodonCharacteristics = @"Características:

  • Mamífero;
  • 3 Metros de comprimento;
  • Grande armadura composta por grossas placas;
  • Extinto com a chegada dos humanos na América do Sul;
  • Cauda possuía espinhos;
  • Pesava 1 tonelada.";
    public int GlyptodonPrice;

    [Header("Vinctifer")]
    public string VinctiferName;
    public string VinctiferScientificName;
    public string VinctiferNickname;
    public Sprite VinctiferSprite;
    public Sprite VinctiferLocation;
    public const string VinctiferCharacteristics = @"Características:

  • Predador;
  • Um dos peixes mais comuns 150 milhões de anos atrás;
  • Focinho fino e pontiagudo com muitos dentes pequenos;
  • Fósseis encontrados do México à Antártica.";
    public int VinctiferPrice;
}
