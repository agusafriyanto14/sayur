using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax ;

}
public class PlayerController : MonoBehaviour 
{
	public Rigidbody rb;
	public float speed;
	public Boundary boundary;

	public int points = 10;

	void Start()
	{
		rb = GetComponent<Rigidbody>();


	}
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f);

		rb.velocity = movement * speed;

		GetComponent<Rigidbody>().position = new Vector3
			(
				Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
			);
		
	}
	private void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 20), "Score :" + points);

	}

}