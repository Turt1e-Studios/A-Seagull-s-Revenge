using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject swarmerPrefab;
    [SerializeField]
    private GameObject v2SwarmerPrefab;
    [SerializeField]
    private GameObject v3SwarmerPrefab;
    [SerializeField]
    private GameObject v4SwarmerPrefab;
    [SerializeField]
    private GameObject v5SwarmerPrefab;
    [SerializeField]
    private GameObject v6SwarmerPrefab;

    [SerializeField]
    private float swarmerInterval = 2f;
    [SerializeField]
    private float V2SwarmerInterval = 5f;
    [SerializeField]
    private float V3SwarmerInterval = 0.5f;
    [SerializeField]
    private float V4SwarmerInterval = 3f;
    [SerializeField]
    private float V5SwarmerInterval = 7f;
    [SerializeField]
    private float V6SwarmerInterval = 9f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
        StartCoroutine(spawnEnemy(V2SwarmerInterval, v2SwarmerPrefab));
        StartCoroutine(spawnEnemy(V3SwarmerInterval, v3SwarmerPrefab));
        StartCoroutine(spawnEnemy(V4SwarmerInterval, v4SwarmerPrefab));
        StartCoroutine(spawnEnemy(V5SwarmerInterval, v5SwarmerPrefab));
        StartCoroutine(spawnEnemy(V6SwarmerInterval, v6SwarmerPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10f, 10), 0, 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
