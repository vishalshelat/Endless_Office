using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mc_movement : MonoBehaviour {

public Rigidbody2D man_move;
public float jumppower;

private void Update(){
    bool jump = Input.GetButtonDown("Jump");
    if (jump){
        man_move.AddForce(new Vector2(0f,jumppower),ForceMode2D.Impulse);
    }
        
}
}
