using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 90 * Time.deltaTime, 90 * Time.deltaTime);
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.name == "Player") 
		{
			other.GetComponent<PlayerController> ().points += 10;
			GetComponent<AudioSource>().Play ();
			Destroy (gameObject);

		}

	}
}
