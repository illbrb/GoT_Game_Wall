using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
	public float lifetime;
	
	void Start ()
	{
		Destroy (gameObject, lifetime);
		}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "ArrowPrefab(Clone)")
		{
			Destroy(coll.gameObject);
		}
	}



}