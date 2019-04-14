using System.Collections;
using UnityEngine;
using UnityEngine.UI;

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
