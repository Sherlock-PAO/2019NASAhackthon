using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float dr;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A))
			transform.Rotate (0, -dr, 0);
		else if (Input.GetKey (KeyCode.D))
			transform.Rotate (0, dr, 0);
	}
}
