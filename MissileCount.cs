using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script determines whether a missle can be fired and changes the text to to reflect if the player has ammunition.//

public class MissileCount : MonoBehaviour
{
    private int missileCount;
    Text missiles;

	void Start ()
    {
        missiles = GetComponent<Text>();
	}
	
	void Update ()
    {

		if(FireMissile.canFire == true)
        {
            missiles.text = "x " + 1;
        }

        if(FireMissile.canFire == false)
        {
            missiles.text = "x " + 0;
        }
	}
}
