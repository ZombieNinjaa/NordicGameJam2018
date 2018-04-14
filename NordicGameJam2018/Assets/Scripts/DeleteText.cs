using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteText : MonoBehaviour {

    public GameObject go_Text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameManager.in_gamestate == 1)
        {
            Destroy(go_Text);
        }
	}
}
