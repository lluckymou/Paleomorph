using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseGenerator : MonoBehaviour
{
    [SerializeField] GameObject FossilChoices;
    [SerializeField] GameObject[] RockFormations;
    [SerializeField] GameObject[] Challenges;

    [SerializeField] float distance = 0;
    [SerializeField] float lastDistance = 0;
    [SerializeField] int subsequentRocks = 0;
    
    void Update()
    {
        if(Player.speed == 0) return;

        distance += Player.speed * Time.deltaTime;

        if(distance > lastDistance) {
            distance = 0;
            
            if(Random.Range(0, 2) == 0 && subsequentRocks < 2)
            {
                Instantiate(RockFormations[Random.Range(0, RockFormations.Length)], new Vector3(0, 0, 115), Quaternion.identity);
                lastDistance = 25;
                subsequentRocks++;
            }
            else
            {
                subsequentRocks = 0;
                int chosenChallenge = Random.Range(0, Challenges.Length);
                FieldElement challenge = Instantiate(Challenges[chosenChallenge], new Vector3(0, 0, 500), Quaternion.identity).GetComponent<FieldElement>();
                float difference = challenge.size - lastDistance;
                lastDistance = challenge.size;
                challenge.transform.position = new Vector3(0, 0, 125 + (challenge.size/2) + difference);
                FossilChoices fc = Instantiate(FossilChoices, new Vector3(0, 0, 125 + (challenge.size/2) + difference - 10), Quaternion.identity).GetComponent<FossilChoices>();
            }
        }
    }
}
