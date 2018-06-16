using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControlCube : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			transform.Translate(Vector3.forward * Time.deltaTime);
		}
		if (Input.GetKey("s")) {
			transform.Translate(Vector3.back * Time.deltaTime);
		}
		if (Input.GetKey("d")) {
			transform.Rotate(0.0f,1f,0.0f);
		}
		if (Input.GetKey("a")) {
			transform.Rotate(0.0f,-1f,0.0f);
		}
		
		
	}
}
