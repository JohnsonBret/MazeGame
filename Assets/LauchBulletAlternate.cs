using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauchBulletAlternate : MonoBehaviour {

	public float speed = 10.0f;
	public GameObject projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			GameObject bullet;
			bullet = Instantiate (projectile, transform.position, transform.rotation);
			Rigidbody bulletBody = bullet.GetComponent<Rigidbody> ();
			bulletBody.velocity = Camera.main.transform.forward * speed;

		}
		
	}
}
