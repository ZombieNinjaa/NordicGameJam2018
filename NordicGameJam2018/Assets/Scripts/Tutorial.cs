using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    private bool bl_WB;
    private bool bl_WBA;
    private bool bl_both;
    public GameObject go_text1;
    public GameObject go_text2;
    public GameObject go_text3;
    public GameObject go_text4;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.bl_WbSpawned)
        {
            go_text1.SetActive(false);
            go_text2.SetActive(true);
            go_text3.SetActive(true);
            if (Raycast.st_selected == "WreckingBall")
            {
                bl_WB = true;
            }
            if (Raycast.st_selected == "WreckingBallAnchor")
            {
                bl_WBA = true;
            }

                if ((Raycast.st_selected != "WreckingBall") && (Raycast.st_selected != "WreckingBallAnchor") && (bl_both))
            {
                go_text3.SetActive(false);
                go_text2.SetActive(false);
                go_text4.SetActive(true);
            }
        }
        if (GameManager.in_gamestate == 1)
        {
            go_text1.SetActive(false);
            go_text2.SetActive(false);
            go_text3.SetActive(false);
            go_text4.SetActive(false);
        }
        if ((bl_WB) &&(bl_WBA))
        {
            bl_both = true;
        }
	}
}
