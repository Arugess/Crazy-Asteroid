using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This spawns the missle and destroys it when it impacts an asteroid or when it has spawned for 5 seconds.//

public class Missile : MonoBehaviour
{
    private Rigidbody2D missileBody;

	void Start ()
    {
        Destroy(this.gameObject, 5.0f);
        
	}
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }
}
