using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour {

	public float speed = 10.0f;
	public Rigidbody projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody clone;
			clone = Instantiate (projectile, transform.position, transform.rotation);
			clone.velocity = Camera.main.transform.forward * speed;
		}
	}
}
