using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainLevel : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] theAsteroid;
    int whichSpawnPoint;

    public string loadLose, loadWin;

    void Start ()
    {
        StartCoroutine("SpawnAsteroids");

        StartCoroutine("SpawnAsteroid2");
	}
	
	void Update ()
    {
        whichSpawnPoint = Random.Range(0, 23);

        if (TimerText.theTimer <= 0 && PlayerStuff.playerHP > 0)
        {
            SceneManager.LoadScene(loadWin);
        }

        if (PlayerStuff.playerHP <= 0)
        {
            SceneManager.LoadScene(loadLose);
        }
    }

    //Spawns asteroids every second
    IEnumerator SpawnAsteroids()
    {
        yield return new WaitForSeconds(1.0f);

        Instantiate(theAsteroid[0], spawnPoints[whichSpawnPoint].position, Quaternion.identity);

        StartCoroutine("SpawnAsteroids");
    }

    IEnumerator SpawnAsteroid2()
    {
        yield return new WaitForSeconds(5.0f);

        Instantiate(theAsteroid[1], spawnPoints[whichSpawnPoint].position, Quaternion.identity);

        StartCoroutine("SpawnAsteroid2");
    }
}
