using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{

    public float fl_explosionforce;
    private Rigidbody2D rb;
    private Vector2 v2;

    public float fl_timer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        

        if (GameManager.in_gamestate == 1)
        {/*
            if (gameObject.name == "ExpUp")
            {
                v2.y = fl_explosionforce;
            }
            if (gameObject.name == "ExpLeft")
            {
                v2.x = -fl_explosionforce;
            }
            if (gameObject.name == "ExpRight")
            {
                v2.x = fl_explosionforce;
            }

            */

            fl_timer -= Time.deltaTime;
            rb.AddForce(transform.up * fl_explosionforce, ForceMode2D.Impulse);
            rb.AddTorque(fl_explosionforce);

            if (fl_timer < 0)
            {
                Destroy(gameObject);
            }
        }



    }
}
