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
		rigidbody.velocity = movement * playerSpeed;
	
	//Player Constraints
		rigidbody.position = new Vector3 (
			Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
			5.0f,
			0.0f
			);
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("space"))
			//Fire
			Instantiate (ArrowPrefab, transform.position, Quaternion.identity);
		
	}

	void onTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "deadly") {
			Debug.Log ("Dead");
		}
	}
}
