using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScore : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Brick")
        {
            GameManager.Score += 10;
            Debug.Log("Score: " + GameManager.Score);
        }
    }
}
