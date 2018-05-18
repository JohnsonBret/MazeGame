using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimer : MonoBehaviour {

	public float Timer = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Countdown();

		if (Timer <= 0) {
			Destroy(gameObject);
		}
	}

	void Countdown()
	{
		Timer -= Time.deltaTime;
	}
}
