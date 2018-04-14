using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBallLimiter : MonoBehaviour {

    public DistanceJoint2D _joint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (_joint.distance > 3.5f)
        {
            _joint.distance = 3.5f;
        }
		
	}
}
