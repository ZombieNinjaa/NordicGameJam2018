using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivvyDamageCount : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Buildings")
        {
            GameManager.Score -= 5;
            Debug.Log("Building Damaged");
        }
    }
}
