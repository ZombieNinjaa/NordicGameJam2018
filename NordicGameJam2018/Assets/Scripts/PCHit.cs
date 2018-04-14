using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCHit : MonoBehaviour {
    public static bool bl_PcHit;

    private void Update()
    {
        if (bl_PcHit == true)
        {
            GameManager.Score -= 100;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bl_PcHit = true;
    }

   
}
