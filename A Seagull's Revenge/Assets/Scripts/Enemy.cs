using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour {

    public int health = 1;
    public Score scoreScript;


    //public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {

            scoreScript.ChangeScore(1);
            
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreObj = GameObject.Find("Score");
        scoreScript = scoreObj.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
