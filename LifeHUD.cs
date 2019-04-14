using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//This shows the players life as text//

public class LifeHUD : MonoBehaviour
{
    public static int liveLeft; 
    Text lives;

	void Start ()
    {
        lives = GetComponent<Text>();
    }
	
	void Update ()
    {
        liveLeft = PlayerStuff.playerHP;

        lives.text = "x " + liveLeft;
	}
}
