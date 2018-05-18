using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

	public NavMeshAgent navAgent;
	public Transform player;
	public float AggroDistance = 30.0f;

	private bool isAggro = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float currentDistance = Vector3.Distance (transform.position, player.position);

		if(currentDistance < AggroDistance){
			isAggro = true;
		}

		if (isAggro == true) {
			navAgent.SetDestination (player.position);
		}
	}

	void OnTriggerEnter(Collider other){

		if (other.tag == "Bullet") {
			Destroy(gameObject);
			Destroy (other.gameObject); 
		}

		if (other.tag == "Player") {
			SceneManager.LoadScene ("Level2");
		}
	}
}
