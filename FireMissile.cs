using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This will make a missile fire from the missle spawner.//

public class FireMissile : MonoBehaviour
{
    public GameObject missile1;
    public Transform earthArrow;
    public static bool canFire;


	void Start ()
    {
        canFire = true;
	}
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Mouse0) && canFire)
        {
 
            GameObject missile1Instance;
            missile1Instance = Instantiate(missile1, earthArrow.position, earthArrow.rotation);
            missile1Instance.GetComponent<Rigidbody2D>().AddForce(transform.up * 600);
            canFire = false;
            StartCoroutine("Reload");
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(3.0f);
        canFire = true;
    }


}
