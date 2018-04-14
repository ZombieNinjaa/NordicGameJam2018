using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static int in_gamestate;

    private bool bl_WbSpawned;
    public GameObject go_WB;
    private bool bl_RocketsSpawned;
    public GameObject go_Rockets;
    private bool bl_ExpSpawned;
    public GameObject go_Explosive;

	// Use this for initialization
	void Start () {
        in_gamestate = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.F1))
        {
            in_gamestate = 0;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            in_gamestate = 1;
        }
		
	}
    public void StartButton()
    {
        if (in_gamestate == 0)
        {
            in_gamestate = 1;
            Debug.Log("Go!");
        }
    }

    public void WBButton()
    {
        if (in_gamestate == 0)
        {
            if (!bl_WbSpawned)
            {
                bl_WbSpawned = true;
                go_WB.SetActive(true);
            }
        }

    }

    public void RocketsButton()
    {
        if (in_gamestate == 0)
        {
            if (!bl_RocketsSpawned)
            {
                bl_RocketsSpawned = true;
                go_Rockets.SetActive(true);
            }
        }
    }

    public void ExplosivesButton()
    {
        if (in_gamestate == 0)
        {
            if (!bl_ExpSpawned)
            {
                bl_ExpSpawned = true;
                go_Explosive.SetActive(true);
            }
        }
    }
}
