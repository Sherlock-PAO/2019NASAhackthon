using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trashDuplicate : MonoBehaviour {

	static int number=10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		System.Random Rpos= new System.Random();
		for (int i = 0; i < number; i++)
			Instantiate (transform, new Vector3 (Rpos.Next(1,10),Rpos.Next(1,10),Rpos.Next(1,10)), Quaternion.identity);
	}
}
