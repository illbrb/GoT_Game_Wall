﻿using UnityEngine;
using System.Collections;

public class textControl : MonoBehaviour {
	
		void Update ()
		{
			if (Input.GetKey(KeyCode.LeftArrow)) {
				Destroy(gameObject);
			}
			
			if (Input.GetKey(KeyCode.RightArrow)) {
				Destroy(gameObject);
			}
		}
}
