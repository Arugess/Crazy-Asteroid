using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will will make the missle spawner track the location of the mouse//

public class FaceMouse : MonoBehaviour
{

	void Start ()
    {
		
    }
	
	void Update ()
    {
        faceMouse();

    }

    void faceMouse()
    {
        //Finds mouse position in level
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Points the arrow towards the mouse
        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);

        transform.up = direction;

    }

}
