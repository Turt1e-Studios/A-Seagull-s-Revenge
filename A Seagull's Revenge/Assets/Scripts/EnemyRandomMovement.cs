using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;

    Vector2 wayPoint;
    
    bool facingRight = true;
    float moveHorizontal;

    

    // Start is called before the first frame update
    void Start()
    {
        //moveHorizontal = Random.Range(-maxDistance, maxDistance);
        SetNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDestination();
        }

        if (wayPoint.x > 0 && !facingRight)
        {
            Flip();
        }
        if (wayPoint.x < 0 && facingRight)
        {
            Flip();
        }
    }

    void SetNewDestination()
    {
        
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), 0);

    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }
}
