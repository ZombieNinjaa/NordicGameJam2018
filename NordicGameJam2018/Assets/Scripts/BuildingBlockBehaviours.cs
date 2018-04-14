using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBlockBehaviours : MonoBehaviour {

    private Rigidbody2D rb;
    public FixedJoint2D _joint;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        _joint.connectedBody = rb;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Mover")
        {
            if (GameManager.in_gamestate == 1)
            {
                _joint.connectedBody = collision.rigidbody;
                Debug.Log(_joint.connectedBody);
            }
        }
    }
    
}
