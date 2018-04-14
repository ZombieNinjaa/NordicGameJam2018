using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketsTut : MonoBehaviour {


    public GameObject go_text1;
    public GameObject go_text2;
    public GameObject go_text3;
    public GameObject go_text4;

    void Update()
    {
        if (GameManager.bl_RocketsSpawned)
        {
            go_text1.SetActive(false);
            go_text2.SetActive(true);
            go_text3.SetActive(true);
            go_text4.SetActive(true);
            
        }
        if (GameManager.in_gamestate == 1)
        {
            go_text1.SetActive(false);
            Destroy(go_text1);
            go_text2.SetActive(false);
            Destroy(go_text2);
            go_text3.SetActive(false);
            Destroy(go_text3);
            go_text4.SetActive(false);
            Destroy(go_text4);
        }
    }
}
