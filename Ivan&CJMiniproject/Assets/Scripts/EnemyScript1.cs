using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript1 : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;

    public float moveSpeed = 5f;

    public int lives = 2;

    public GameObject animation;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        direction.Normalize();

        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            
            lives -= 1;
            Destroy(collision.gameObject);
            if (lives <= 0)
            {
                Destroy(gameObject);
                Instantiate(animation, transform.position, Quaternion.identity);
                
             
            }
        }    

        if(collision.gameObject.tag == "Core")
        {
            Destroy(gameObject);
        }
    }
}
