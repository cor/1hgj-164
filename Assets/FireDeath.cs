﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.tag == "Player") {
			GameObject.Find("GameManager").GetComponent<GameManager>().PlayerDied();
		}
	}
}
