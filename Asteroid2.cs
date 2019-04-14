using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This Asteroid continuosly tracks and follows the player.//
public class Asteroid2 : MonoBehaviour
{
    //The speed, and rigidbody of the asteroid
    float asteroid2Speed = 3.5f;
    Transform target2;
    private bool canTrack;
    Animator asteroidAnim2;

    void Start()
    {
        //Gets the animator
        asteroidAnim2 = GetComponent<Animator>();

        //target finds the players initial coordinates, startDir  
        target2 = GameObject.FindWithTag("Player").transform;
        canTrack = true;
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        float moveAsteroid2 = asteroid2Speed * Time.deltaTime;

        if(canTrack == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target2.position, moveAsteroid2);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Missile")
        {
            canTrack = false;
            asteroidAnim2.SetTrigger("dead");
            StartCoroutine("DestroyAsteroid2");
        }


    }

    IEnumerator DestroyAsteroid2()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
