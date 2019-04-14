using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This asteroid tracks the players position when it initially spawns.// 
//It will move to the players position but won't continuosly chase the player.// 
public class Asteroid1 : MonoBehaviour
{
    //The speed, and rigidbody of the asteroid
    float asteroidSpeed = 4.0f;
    Transform target;

    Animator asteroidAnim;

    Vector2 startDir;

    void Start ()
    {
        //Gets the animator
        asteroidAnim = GetComponent<Animator>();
     
        //target finds the players initial coordinates, startDir prevent the asteroid from contiously tracking the player
        target = GameObject.FindWithTag("Player").transform;
        startDir = target.position;
    }
	
	void Update ()
    {

    }

    private void FixedUpdate()
    {
        float moveAsteroid = asteroidSpeed * Time.deltaTime;


        transform.position = Vector2.MoveTowards(transform.position, startDir, moveAsteroid);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Missile")
        {
            asteroidAnim.SetTrigger("kill");
            StartCoroutine("DestroyAsteroid");
        }


    }

    IEnumerator DestroyAsteroid()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
