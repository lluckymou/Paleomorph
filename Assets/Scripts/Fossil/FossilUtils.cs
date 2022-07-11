using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilUtils : SceneSingleton<FossilUtils>
{
    [SerializeField] GameObject[] RockPrefabs;
    [SerializeField] Material[] RockMaterials;

    public GameObject NewRock(Sprite texture, Transform parent)
    {
        if(RockPrefabs.Length < 1 || RockMaterials.Length < 1) return null;

        Material randomMaterial = RockMaterials[Random.Range(0, RockMaterials.Length)];
        int chosenRock = Random.Range(0, RockPrefabs.Length);

        GameObject obj = Instantiate(RockPrefabs[chosenRock], parent);
        obj.GetComponent<MeshRenderer>().material = randomMaterial;
        
        obj.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = texture;
        obj.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.Lerp(randomMaterial.color, Color.black, .5f);

        return obj;
    }
}
