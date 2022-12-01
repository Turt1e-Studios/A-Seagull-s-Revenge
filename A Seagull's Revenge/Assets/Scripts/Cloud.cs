using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;

    int velocity;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(1, 3) == 1)
        {
            velocity = Random.Range(1, 3);
        }
        else
        {
            velocity = Random.Range(-1, -3);
        }
        if (Random.Range(1, 3) == 1)
        {
            spriteRenderer.sprite = sprite1;
        }
        else
        {
            spriteRenderer.sprite = sprite2;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(velocity * Time.deltaTime, 0, 0);
    }

    // cloud moves in a direction
}
