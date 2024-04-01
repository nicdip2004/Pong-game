using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = 10.0f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    
    }
    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(60, 50));
        }
        else
        {
            rb2d.AddForce(new Vector2(-60, 50));

        }
    }

    void ResetBall()
     {
        rb2d.velocity = Vector2.zero;
            transform.position = Vector2.zero;
        }

        void RestartGame()
        {
            ResetBall();
            Invoke("GoBall", 1);
        }

        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.collider.CompareTag("Player"))
            {
                Vector2 vel;
                vel.x = rb2d.velocity.x;
                vel.y = rb2d.velocity.y;
                rb2d.velocity = vel;
            }

        }

}
