using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWallOne : MonoBehaviour {

	public string TagToFind;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bullet") {
			Destroy (GameObject.FindWithTag (TagToFind));
			Destroy (gameObject);
		}
	}
}
