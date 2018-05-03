using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour {
	public Rigidbody wall;
	public float dir = 1f, speed;
	// Update is called once per frame
	void Update () {
		Vector3 rigispeed = wall.velocity;
		rigispeed.z = speed * dir;
		wall.velocity = rigispeed;
	}
	void OnCollisionEnter(Collision col){
		dir = -dir;
		if(col.gameObject.tag=="Player"){
			Destroy(col.gameObject);

		}
	}
}
