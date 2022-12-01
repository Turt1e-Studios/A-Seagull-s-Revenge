using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    //public GameObject ant;
    public GameObject Bullet;
    public Transform bulletPos;
    public Animator animator;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        //wp = bool_script = ant.GetComponent<EnemyRandomMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            shoot();
        }

        if(timer <= 0)
        {
            //animator.SetBool("IsBullet", false);
        }
    }
    void shoot()
    {
        
        Instantiate(Bullet, bulletPos.position, Quaternion.identity);
        
        //animator.SetBool("IsBullet", true);
    }

}
