using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

//This makes the text for the timer to count downward.//

public class TimerText : MonoBehaviour
{

    Text time; 
    public static float theTimer = 120.0f;

    void Start()
    {
        time = GetComponent<Text>();
    }


    void Update()
    {
        //Counts down time in whole seconds.
        time.text = "Time: " + Mathf.Round(theTimer -= Time.deltaTime);



    }

}
