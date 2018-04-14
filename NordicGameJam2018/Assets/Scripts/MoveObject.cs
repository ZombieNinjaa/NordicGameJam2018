using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    private string st_objectName;
    private Rigidbody2D rb;
    private Transform t_parent;
    private int rotate;
    void Start () {
        st_objectName = name;
        rb = GetComponent<Rigidbody2D>();
        
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = Input.mousePosition;
        temp.z = 1;
        if ((st_objectName == Raycast.st_selected) && (GameManager.in_gamestate == 0))
        {
            this.transform.position = Camera.main.ScreenToWorldPoint(temp);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Raycast.st_selected = "";
            rotate = 0;
        }
        if ((st_objectName != Raycast.st_selected) && (GameManager.in_gamestate == 0))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (GameManager.in_gamestate == 1)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if ((Input.GetMouseButtonDown(1)) && (st_objectName == Raycast.st_selected))
        {
            rotate += 1;
            if ((rotate > 1) &&(st_objectName != "WreckingBall"))
            {
                gameObject.transform.Rotate(0, 0, 45);
                rotate += 1;
            }
        }

    }
}
