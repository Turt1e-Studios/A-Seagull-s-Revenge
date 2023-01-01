using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public float foodSpawnInterval;
    public int spawningRange;
    [SerializeField]
    private GameObject swarmerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnFood(foodSpawnInterval, swarmerPrefab));
    }

    private IEnumerator spawnFood(float interval, GameObject food)
    {
        yield return new WaitForSeconds(interval);
        Instantiate(food, new Vector3(Random.Range(-1 * spawningRange, spawningRange), gameObject.transform.position.y, 0), Quaternion.identity);
        StartCoroutine(spawnFood(interval, food));
    }
}
