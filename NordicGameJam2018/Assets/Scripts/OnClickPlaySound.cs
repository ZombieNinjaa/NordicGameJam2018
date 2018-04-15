using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickPlaySound : MonoBehaviour {

    public AudioSource _audio;
    private bool bl_playing;
	// Use this for initialization
	void Start () {
        _audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if ((GameManager.in_gamestate == 1) && (!bl_playing))
        {
            _audio.Play();
            bl_playing = true;
        }
		
	}
}
