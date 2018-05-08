using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D (Collider2D trigger) {
		print("trigger");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print("Collision");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
