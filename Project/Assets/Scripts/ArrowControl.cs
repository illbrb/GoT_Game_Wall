using UnityEngine;
using System.Collections;

public class ArrowControl : MonoBehaviour {

	public float arrowSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float amountToMove = arrowSpeed * Time.deltaTime;
		transform.Translate (Vector3.down * amountToMove);

		if (transform.position.y < -7.5f)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "enemySpawn")
		{
			Destroy(other.gameObject);
		}


}
}