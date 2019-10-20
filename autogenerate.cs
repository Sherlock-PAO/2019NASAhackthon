using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autogenerate : MonoBehaviour {
	public Vector3 center;
	public Vector3 size;
	public GameObject Trash;
	public int number;
	public Transform ship;
	public float Range;


	// Use this for initialization
	void Start () {
		for (int i = 0; i < number; i++) {
			Spawn();
		}
	}

	public void Spawn(){
		Vector3 pos = new Vector3 ();
		do{
			pos = center + new Vector3 (Random.Range(-size.x/2,size.x/2),Random.Range(-size.y/2,size.y/2),Random.Range(-size.z/2,size.z/2));
		}while(Vector3.Distance(ship.position,pos)<Range);
		Quaternion angle;
		angle.w = Random.Range(-180,180);
		angle.x = 0;
		angle.y = Random.Range(-180,180);
		angle.z = Random.Range(-180,180);
		Instantiate (Trash,pos,angle);


	}

	void OnDrawGizmosSelected(){
		Gizmos.color = new Color (1,0,0,0.5f);
		Gizmos.DrawCube (center, size); 
	}
}
