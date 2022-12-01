using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Transform playerTransform;
    Player playerScript;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerScript = player.GetComponent<Player>();
        playerTransform = player.GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector2.Distance(playerTransform.position, gameObject.transform.position) < 1)
        {
            // gains 1 health
            playerScript.TakeDamage(-1);
            Destroy(gameObject);
        }
    }

    //void OnTriggerEnter2D(Collider2D hitInfo)
    //{
    //    Player player = hitInfo.GetComponent<Player>();
    //    if (player != null)
    //    {
    //        // gains 1 health
    //        playerScript.TakeDamage(-1);
    //        Destroy(gameObject);
    //    }
    //}
}
