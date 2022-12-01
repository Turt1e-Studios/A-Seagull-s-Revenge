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
    private float swarmerInterval = 3.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
        //StartCoroutine(spawnEnemy(swarmerInterval, v2SwarmerPrefab));
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
