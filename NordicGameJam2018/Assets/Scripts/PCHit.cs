using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCHit : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        Debug.Log("PC Hit, Game Over");
    }
}
