using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoSquare : MonoBehaviour

{
    public float speed = 4;
    public Vector2 direction = Vector2.right;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Collider>( ) != null )
        {
            rb.velocity = Vector2.zero;
        }
    }

}
