using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis("Horizontal");
		Rigidbody2D rb = GetComponent<Rigidbody2D>();

		rb.AddForce(new Vector2(horizontalInput * moveSpeed, 0));
	}

	public void SwitchVelocity() {
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2 (-rb.velocity.y, rb.velocity.x);

	}
}
