using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    void FixedUpdate()
    {

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.up); //transform.position, );
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null)
            {
                Debug.Log("hit " + hit.rigidbody.name);
            }
        }
    }
}
