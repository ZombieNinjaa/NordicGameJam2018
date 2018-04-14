using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static int in_gamestate;
    public static int Score;
    public Text tx_score;
    public float fl_levelTimer;

    public GameObject go_gameOverScreen;
    public GameObject go_LevelOverScreen;
    
    public static bool bl_WbSpawned;
    public GameObject go_WB;
    private bool bl_RocketsSpawned;
    public GameObject go_Rockets;
    private bool bl_ExpSpawned;
    public GameObject go_Explosive;

	// Use this for initialization
	void Start () {
        in_gamestate = 0;
        Score = 0;	
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
        if (in_gamestate == 1)
        {
            fl_levelTimer -= Time.deltaTime;
        }
        if (fl_levelTimer < 0 )
        {
            go_LevelOverScreen.SetActive(true);
            in_gamestate = 0;
        }
        if (PCHit.bl_PcHit)
        {
            go_gameOverScreen.SetActive(true);
            in_gamestate = 0;
        }
        tx_score.text = "Score: " + Score.ToString();
	}


    #region Buttons
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
    #endregion
}
