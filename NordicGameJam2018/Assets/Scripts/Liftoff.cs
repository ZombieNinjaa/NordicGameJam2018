using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liftoff : MonoBehaviour {

    public float fl_explosionForce;
    private Rigidbody2D rb;
    private Vector2 v2;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //v2.x = fl_explosionForce;
        v2.y = fl_explosionForce;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.in_gamestate == 1)
        {
            rb.AddForce(v2);
        }

    }
}
