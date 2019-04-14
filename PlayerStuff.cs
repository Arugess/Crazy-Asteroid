using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This calls on the rigidbody attached to the player and allows it to move.//
//It also causes the player to lose health when it touches an asteroid.//

public class PlayerStuff : MonoBehaviour
{
    private Rigidbody2D earthBody;
    private float earthSpeed = 0.05f;
    public static int playerHP = 3; 

	void Start ()
    {
        earthBody = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {
        float moveHori = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHori, moveVert);

        earthBody.transform.Translate(movement * earthSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            playerHP -= 1;
        }
    }
}
