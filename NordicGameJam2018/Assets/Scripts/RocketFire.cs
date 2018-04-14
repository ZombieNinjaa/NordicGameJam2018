using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFire : MonoBehaviour {
    public Animator _animator;
	// Use this for initialization
	void Start () {
        
		

    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.in_gamestate == 1)
        {
            _animator.SetBool("bl_IsMoving", true);
        }
		
	}
}
