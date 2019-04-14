using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
