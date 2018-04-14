using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCHit : MonoBehaviour {
    public static bool bl_PcHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        Debug.Log("PC Hit, Game Over");
        bl_PcHit = true;
    }
}
