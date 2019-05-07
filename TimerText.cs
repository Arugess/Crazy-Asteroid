using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

//This makes the text for the timer to count downward.//

public class TimerText : MonoBehaviour
{

    Text time; 
    public static float theTimer;

    void Start()
    {
        time = GetComponent<Text>();
        theTimer = 60.0f;
    }


    void Update()
    {
        //Counts down time in whole seconds.
        time.text = "Time: " + Mathf.Round(theTimer -= Time.deltaTime);



    }

}
