using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {


	public GameObject bluePortal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.tag == "Player") {
			collider.gameObject.transform.position = new Vector2(bluePortal.transform.position.x + 0.5f, bluePortal.transform.position.y);
		}
	}
}
