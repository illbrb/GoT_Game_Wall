using UnityEngine;
using System.Collections;

[System.Serializable]
	public class Boundary

{
	public float xMin, xMax;
}


public class CrowControl : MonoBehaviour 
{
	public float playerSpeed;
	public Boundary boundary;
	public GameObject ArrowPrefab;
	
	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3 (0f, 5.0f, 0);
	}

	void FixedUpdate()
	{
	// Player Movement
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0);
		GetComponent<Rigidbody>().velocity = movement * playerSpeed;
	
	//Player Constraints
		GetComponent<Rigidbody>().position = new Vector3 (
			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
			5.0f,
			0.0f
			);
	}
	

	// Update is called once per frame
	void Update () 
	{
		//Arrow Trigger
		if (Input.GetKeyDown(KeyCode.Space))

			//Fires Arrow
			Instantiate (ArrowPrefab, transform.position, Quaternion.identity);	
	}
}
