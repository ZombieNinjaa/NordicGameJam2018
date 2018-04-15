using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static int in_gamestate;
    private int in_tempgamestate;
    public static int Score;
    public Text tx_score;
    public float fl_levelTimer;
    private bool bl_paused;
    public static int in_noOfStars;
    private bool bl_doneScores;
    public AudioSource _audio;

    public GameObject go_PauseScreen;
    public GameObject go_gameOverScreen;
    public GameObject go_LevelOverScreen;
    public GameObject go_StartButtonPressed;
    public GameObject go_endscreen1star;
    public GameObject go_endscreen2stars;
    public GameObject go_endscreen3stars;
    
    public static bool bl_WbSpawned;
    public GameObject go_WB;
    public static bool bl_RocketsSpawned;
    public GameObject go_Rockets;
    public static bool bl_ExpSpawned;
    public GameObject go_Explosive;

	// Use this for initialization
	void Start () {
        in_gamestate = 0;
        Score = 0;
        bl_paused = false;
        _audio = GetComponent<AudioSource>();
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
            if (!bl_doneScores)
            {


                go_LevelOverScreen.SetActive(true);
                in_gamestate = 0;
                Scores();
                if (in_noOfStars == 1)
                {
                    go_endscreen1star.SetActive(true);
                }
                if (in_noOfStars == 2)
                {
                    go_endscreen2stars.SetActive(true);
                }
                if (in_noOfStars == 3)
                {
                    go_endscreen3stars.SetActive(true);
                }
                bl_doneScores = true;   
            }
        }
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (bl_paused == false)
            {
                Pause();
                bl_paused = true;
            }
        }
        tx_score.text = "Score: " + Score.ToString();
        if (Score <= 20)
        {
            in_noOfStars = 1;
        }
        if ((Score <= 60)&&(Score>20))
        {
            in_noOfStars = 2;
        }
        if (Score > 60)
        {
            in_noOfStars = 3;
        }
        
	}
    private void Pause()
    {
        Debug.Log("Paused");
        in_tempgamestate = in_gamestate;
        in_gamestate = 0;
        go_PauseScreen.SetActive(true);

    }
    private void Unpause()
    {
        Debug.Log("Unpaused");
        in_gamestate = in_tempgamestate;
        go_PauseScreen.SetActive(false);
        bl_paused = false;
    }
    private void Scores()
    {

        if (bl_ExpSpawned)
        {
            Score -= 5;
        }
        if (bl_RocketsSpawned)
        {
            Score -= 10;
        }
       
    }

    #region Buttons
    public void RestartLevelButton()
    {
        Scene _scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(_scene.name);
        Unpause();
        bl_RocketsSpawned = false;
        bl_WbSpawned = false;
        bl_ExpSpawned = false;
        Score = 0;
        PCHit.bl_PcHit = false;
        _audio.Play();
    }

    public void LevelSelectButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Level Select");   
    }

    public void WreckingBallTutSelectButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Wreckingball Tutorial");
    }

    public void RocketsTutSelectButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Rockets Tutorial");
    }

    public void ExplosivesTutSelectButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Explosives Tutorial");
    }

    public void OtherBuildingsSelectTutButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Other Buildings");
    }

    public void MoreBuildingsSelectButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Level5");
    }

    public void MainMenuButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Start Scene");
    }

    public void CreditsButton()
    {
        _audio.Play();
        SceneManager.LoadScene("Credits");
    }

    public void QuitButton()
    {
        _audio.Play();
        Application.Quit();
    }

    public void ReturnButton()
    {
        _audio.Play();
        Unpause();
    }

    public void StartButton()
    {
        _audio.Play();
        if (in_gamestate == 0)
        {
            in_gamestate = 1;
            Debug.Log("Go!");
            go_StartButtonPressed.SetActive(true);
        }
    }

    public void WBButton()
    {
        _audio.Play();
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
        _audio.Play();
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
        _audio.Play();
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
