using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constant_movement : MonoBehaviour {
public Rigidbody2D man_move;
public float screenspeed;
public void FixedUpdate(){
     man_move.velocity = new Vector2(screenspeed,man_move.velocity.y);
}
	

	// Update is called once per frame
	void Update () {
		
	}
}
