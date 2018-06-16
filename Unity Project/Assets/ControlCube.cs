using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCube : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	float velocity;
	float x = 0;
	float acceleration = 10;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			velocity += acceleration * Time.deltaTime;
		} else {
			if (velocity > 0) {
				velocity -= acceleration * Time.deltaTime;
			}
		}
		if (Input.GetKey("s")) {
			velocity -= acceleration * Time.deltaTime;
		} else {
			if (velocity < 0) {
				velocity += acceleration * Time.deltaTime;
			}
		}
		//velocity = 100 - (x * x);
		if (velocity <= 0.01 & velocity >= -0.01) {
			velocity = 0;
		} 
		transform.Translate(Vector3.forward * velocity * Time.deltaTime);
		
		if (Input.GetKey("d")) {
			transform.Rotate(0.0f,1f,0.0f);
		}
		if (Input.GetKey("a")) {
			transform.Rotate(0.0f,-1f,0.0f);
		}
		
		
	}
}
