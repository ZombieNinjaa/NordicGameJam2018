using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivvyBuildings : MonoBehaviour {

    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.in_gamestate == 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (GameManager.in_gamestate == 1)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }
}
