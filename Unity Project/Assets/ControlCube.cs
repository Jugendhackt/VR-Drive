using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math; 


public class ControlCube : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}

	float x = 0;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			x += 1.0f;
		} else {
			x -= 0.5f;
		}
		if (Input.GetKey("s")) {
			x -= 1.0f;
		}

		transform.Translate(Vector3.forward * 100 - Math.Pow(x, 2) * Time.deltaTime);
		
		if (Input.GetKey("d")) {
			transform.Rotate(0.0f,1f,0.0f);
		}
		if (Input.GetKey("a")) {
			transform.Rotate(0.0f,-1f,0.0f);
		}
		
		
	}
}
