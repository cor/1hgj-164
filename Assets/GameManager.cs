using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject deathScreen;
	public Transform spawnPoint;
	public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerDied () {
		deathScreen.SetActive(true);
		Invoke("Respawn", 2.0f);
	}

	public void Respawn() {
		player.transform.position = spawnPoint.transform.position;
		deathScreen.SetActive(false);
	}
}
