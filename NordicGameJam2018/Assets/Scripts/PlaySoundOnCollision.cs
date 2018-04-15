using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour {

    public AudioSource _audio;
    private bool bl_Playing;
    // Use this for initialization
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.transform.tag == "Brick") &&(!bl_Playing))
        {
            _audio.Play();
            bl_Playing = true;
        }
    }
}
