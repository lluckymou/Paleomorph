using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseGenerator : SceneSingleton<CourseGenerator>
{
    [SerializeField] GameObject FossilChoices;
    [SerializeField] GameObject[] RockFormations;
    [SerializeField] GameObject[] Challenges;

    [SerializeField] int subsequentRocks = 0;
    [SerializeField] Transform last;

    void Start()
    {
        GenerateElement(true);
        GenerateElement(false);
        GenerateElement(Random.Range(0, 2) == 0);
        GenerateElement(Random.Range(0, 2) == 0);
        GenerateElement(false);
    }

    public void NewElement()
    {
        if(subsequentRocks < 2 && Random.Range(0, 2) == 0)
        {
            subsequentRocks++;
            GenerateElement(true);
        }
        else
        {
            subsequentRocks = 0;
            GenerateElement(false);
        }
    }

    void GenerateElement(bool isRock)
    {
        int chosenElement = isRock ? Random.Range(0, RockFormations.Length) : Random.Range(0, Challenges.Length);
        FieldElement element;

        if(isRock)
            element = Instantiate(RockFormations[chosenElement], new Vector3(0, 0, 500), Quaternion.identity).GetComponent<FieldElement>();
        else
            element = Instantiate(Challenges[chosenElement], new Vector3(0, 0, 500), Quaternion.identity).GetComponent<FieldElement>();
 
        element.transform.position = last? last.position + new Vector3(0, 0, element.size) : new Vector3(0, 0, 25);
        last = element.transform;
    }
}
