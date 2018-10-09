using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlscript : MonoBehaviour {

	public void OnCollisionEnter2D(Collision2D onhit){
        if (onhit.collider.gameObject.name == "MC"){          
            Destroy(onhit.collider.gameObject);

        }
 
    }
    
	void Update () {
		
	}
}
