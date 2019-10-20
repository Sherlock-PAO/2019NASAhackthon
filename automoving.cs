using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automoving : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float ds;
	public float dd;
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * Time.deltaTime * ds);
		transform.Translate (Vector3.forward * Time.deltaTime * ds * dd);
		transform.Translate (Vector3.up * Time.deltaTime * ds * dd);

	}
}
