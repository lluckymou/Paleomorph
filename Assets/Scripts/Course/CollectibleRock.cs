using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleRock : MonoBehaviour
{
    Transform rock;

    void Start()
    {
        rock = FossilUtils.instance.NewRock(null, transform).transform;
        rock.localPosition = new Vector3(0, rock.GetComponent<RockPositionDifference>().Difference.y, 0);
        Destroy(rock.GetComponent<ParticleSystem>());
    }

    void Update() => rock.Rotate(0, 50 * Time.deltaTime, 0);

    void OnTriggerEnter(Collider col)
    {
        Inventory.Rocks++;
        Destroy(gameObject);
    }
}
