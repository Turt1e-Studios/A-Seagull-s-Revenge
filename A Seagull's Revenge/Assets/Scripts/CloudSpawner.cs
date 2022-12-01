using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public float cloudSpawnInterval;
    public int spawningRange;
    [SerializeField]
    private GameObject cloudPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnFood(cloudSpawnInterval, cloudPrefab));
    }

    private IEnumerator spawnFood(float interval, GameObject obj)
    {
        yield return new WaitForSeconds(interval);
        float yPos = gameObject.transform.position.y;
        Instantiate(obj, new Vector3(Random.Range(-1 * spawningRange, spawningRange), Random.Range(yPos-1.5f, yPos+1.5f), 0), Quaternion.identity);
        StartCoroutine(spawnFood(interval, obj));
    }
}
