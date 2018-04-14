using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public GameObject go_LevelSelect;
    public GameObject go_Exit;
    public GameObject go_Restart;
	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate()
    {

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.up);
        Debug.Log(hit);//transform.position, );
        if (hit.collider.name == "LevelSelect")
        {
            go_LevelSelect.SetActive(true);
            go_Exit.SetActive(false);
            go_Restart.SetActive(false);
        }
        if (hit.collider.name == "Exit")
        {
            go_LevelSelect.SetActive(false);
            go_Exit.SetActive(true);
            go_Restart.SetActive(false);
        }
        if (hit.collider.name == "Restart")
        {
            go_LevelSelect.SetActive(false);
            go_Exit.SetActive(false);
            go_Restart.SetActive(true);
        }
    }

}

